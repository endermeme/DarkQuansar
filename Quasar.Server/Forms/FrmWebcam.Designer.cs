namespace Quasar.Server.Forms
{
    partial class FrmWebcam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFrameRateValue = new System.Windows.Forms.Label();
            this.lblQualityValue = new System.Windows.Forms.Label();
            this.trackBarFrameRate = new System.Windows.Forms.TrackBar();
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCaptureImage = new System.Windows.Forms.Button();
            this.btnStopWebcam = new System.Windows.Forms.Button();
            this.btnStartWebcam = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstClients);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Clients";
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "lstClients";
            this.groupBox1.Size = new System.Drawing.Size(388, 108);
            this.groupBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Clients:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFrameRateValue);
            this.groupBox2.Controls.Add(this.lblQualityValue);
            this.groupBox2.Controls.Add(this.trackBarFrameRate);
            this.groupBox2.Controls.Add(this.trackBarQuality);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Webcam Settings";
            // 
            // lblFrameRateValue
            // 
            this.lblFrameRateValue.AutoSize = true;
            this.lblFrameRateValue.Location = new System.Drawing.Point(350, 85);
            this.lblFrameRateValue.Name = "lblFrameRateValue";
            this.lblFrameRateValue.Size = new System.Drawing.Size(13, 13);
            this.lblFrameRateValue.TabIndex = 6;
            this.lblFrameRateValue.Text = "10";
            // 
            // lblQualityValue
            // 
            this.lblQualityValue.AutoSize = true;
            this.lblQualityValue.Location = new System.Drawing.Point(350, 45);
            this.lblQualityValue.Name = "lblQualityValue";
            this.lblQualityValue.Size = new System.Drawing.Size(13, 13);
            this.lblQualityValue.TabIndex = 5;
            this.lblQualityValue.Text = "50";
            // 
            // trackBarFrameRate
            // 
            this.trackBarFrameRate.Location = new System.Drawing.Point(120, 75);
            this.trackBarFrameRate.Maximum = 30;
            this.trackBarFrameRate.Minimum = 1;
            this.trackBarFrameRate.Name = "trackBarFrameRate";
            this.trackBarFrameRate.Size = new System.Drawing.Size(224, 45);
            this.trackBarFrameRate.TabIndex = 4;
            this.trackBarFrameRate.Value = 10;
            this.trackBarFrameRate.ValueChanged += new System.EventHandler(this.trackBarFrameRate_ValueChanged);
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Location = new System.Drawing.Point(120, 35);
            this.trackBarQuality.Maximum = 100;
            this.trackBarQuality.Minimum = 10;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(224, 45);
            this.trackBarQuality.TabIndex = 3;
            this.trackBarQuality.Value = 50;
            this.trackBarQuality.ValueChanged += new System.EventHandler(this.trackBarQuality_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Frame Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quality:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Webcam Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCaptureImage);
            this.groupBox3.Controls.Add(this.btnStopWebcam);
            this.groupBox3.Controls.Add(this.btnStartWebcam);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btnCaptureImage
            // 
            this.btnCaptureImage.Location = new System.Drawing.Point(270, 30);
            this.btnCaptureImage.Name = "btnCaptureImage";
            this.btnCaptureImage.Size = new System.Drawing.Size(124, 30);
            this.btnCaptureImage.TabIndex = 2;
            this.btnCaptureImage.Text = "Start Capturing";
            this.btnCaptureImage.UseVisualStyleBackColor = true;
            this.btnCaptureImage.Click += new System.EventHandler(this.btnCaptureImage_Click);
            // 
            // btnStopWebcam
            // 
            this.btnStopWebcam.Location = new System.Drawing.Point(140, 30);
            this.btnStopWebcam.Name = "btnStopWebcam";
            this.btnStopWebcam.Size = new System.Drawing.Size(124, 30);
            this.btnStopWebcam.TabIndex = 1;
            this.btnStopWebcam.Text = "Stop Webcam";
            this.btnStopWebcam.UseVisualStyleBackColor = true;
            this.btnStopWebcam.Click += new System.EventHandler(this.btnStopWebcam_Click);
            // 
            // btnStartWebcam
            // 
            this.btnStartWebcam.Location = new System.Drawing.Point(10, 30);
            this.btnStartWebcam.Name = "btnStartWebcam";
            this.btnStartWebcam.Size = new System.Drawing.Size(124, 30);
            this.btnStartWebcam.TabIndex = 0;
            this.btnStartWebcam.Text = "Start Webcam";
            this.btnStartWebcam.UseVisualStyleBackColor = true;
            this.btnStartWebcam.Click += new System.EventHandler(this.btnStartWebcam_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(337, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 415);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWebcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Webcam Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarFrameRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQualityValue;
        private System.Windows.Forms.Label lblFrameRateValue;
        private System.Windows.Forms.Button btnStartWebcam;
        private System.Windows.Forms.Button btnStopWebcam;
        private System.Windows.Forms.Button btnCaptureImage;
    }
}

namespace Quasar.Server.Forms
{
    partial class FrmVirtualDesktop
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
            this.txtProcessArgs = new System.Windows.Forms.TextBox();
            this.txtProcessPath = new System.Windows.Forms.TextBox();
            this.txtDesktopName = new System.Windows.Forms.TextBox();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRunHiddenProcess = new System.Windows.Forms.Button();
            this.btnDestroyVirtualDesktop = new System.Windows.Forms.Button();
            this.btnSwitchToVirtualDesktop = new System.Windows.Forms.Button();
            this.btnCreateVirtualDesktop = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.txtProcessArgs);
            this.groupBox2.Controls.Add(this.txtProcessPath);
            this.groupBox2.Controls.Add(this.txtDesktopName);
            this.groupBox2.Controls.Add(this.txtStationName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Virtual Desktop Settings";
            // 
            // txtProcessArgs
            // 
            this.txtProcessArgs.Location = new System.Drawing.Point(120, 100);
            this.txtProcessArgs.Name = "txtProcessArgs";
            this.txtProcessArgs.Size = new System.Drawing.Size(274, 20);
            this.txtProcessArgs.TabIndex = 5;
            // 
            // txtProcessPath
            // 
            this.txtProcessPath.Location = new System.Drawing.Point(120, 80);
            this.txtProcessPath.Name = "txtProcessPath";
            this.txtProcessPath.Size = new System.Drawing.Size(274, 20);
            this.txtProcessPath.TabIndex = 4;
            // 
            // txtDesktopName
            // 
            this.txtDesktopName.Location = new System.Drawing.Point(120, 60);
            this.txtDesktopName.Name = "txtDesktopName";
            this.txtDesktopName.Size = new System.Drawing.Size(274, 20);
            this.txtDesktopName.TabIndex = 3;
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(120, 25);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(274, 20);
            this.txtStationName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Arguments:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Process Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desktop Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Station Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRunHiddenProcess);
            this.groupBox3.Controls.Add(this.btnDestroyVirtualDesktop);
            this.groupBox3.Controls.Add(this.btnSwitchToVirtualDesktop);
            this.groupBox3.Controls.Add(this.btnCreateVirtualDesktop);
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btnRunHiddenProcess
            // 
            this.btnRunHiddenProcess.Location = new System.Drawing.Point(270, 30);
            this.btnRunHiddenProcess.Name = "btnRunHiddenProcess";
            this.btnRunHiddenProcess.Size = new System.Drawing.Size(124, 30);
            this.btnRunHiddenProcess.TabIndex = 3;
            this.btnRunHiddenProcess.Text = "Run Hidden Process";
            this.btnRunHiddenProcess.UseVisualStyleBackColor = true;
            this.btnRunHiddenProcess.Click += new System.EventHandler(this.btnRunHiddenProcess_Click);
            // 
            // btnDestroyVirtualDesktop
            // 
            this.btnDestroyVirtualDesktop.Location = new System.Drawing.Point(140, 60);
            this.btnDestroyVirtualDesktop.Name = "btnDestroyVirtualDesktop";
            this.btnDestroyVirtualDesktop.Size = new System.Drawing.Size(124, 30);
            this.btnDestroyVirtualDesktop.TabIndex = 2;
            this.btnDestroyVirtualDesktop.Text = "Destroy Virtual Desktop";
            this.btnDestroyVirtualDesktop.UseVisualStyleBackColor = true;
            this.btnDestroyVirtualDesktop.Click += new System.EventHandler(this.btnDestroyVirtualDesktop_Click);
            // 
            // btnSwitchToVirtualDesktop
            // 
            this.btnSwitchToVirtualDesktop.Location = new System.Drawing.Point(10, 60);
            this.btnSwitchToVirtualDesktop.Name = "btnSwitchToVirtualDesktop";
            this.btnSwitchToVirtualDesktop.Size = new System.Drawing.Size(124, 30);
            this.btnSwitchToVirtualDesktop.TabIndex = 1;
            this.btnSwitchToVirtualDesktop.Text = "Switch to Virtual Desktop";
            this.btnSwitchToVirtualDesktop.UseVisualStyleBackColor = true;
            this.btnSwitchToVirtualDesktop.Click += new System.EventHandler(this.btnSwitchToVirtualDesktop_Click);
            // 
            // btnCreateVirtualDesktop
            // 
            this.btnCreateVirtualDesktop.Location = new System.Drawing.Point(10, 30);
            this.btnCreateVirtualDesktop.Name = "btnCreateVirtualDesktop";
            this.btnCreateVirtualDesktop.Size = new System.Drawing.Size(124, 30);
            this.btnCreateVirtualDesktop.TabIndex = 0;
            this.btnCreateVirtualDesktop.Text = "Create Virtual Desktop";
            this.btnCreateVirtualDesktop.UseVisualStyleBackColor = true;
            this.btnCreateVirtualDesktop.Click += new System.EventHandler(this.btnCreateVirtualDesktop_Click);
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
            // FrmVirtualDesktop
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
            this.Name = "FrmVirtualDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Virtual Desktop Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProcessArgs;
        private System.Windows.Forms.TextBox txtProcessPath;
        private System.Windows.Forms.TextBox txtDesktopName;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRunHiddenProcess;
        private System.Windows.Forms.Button btnDestroyVirtualDesktop;
        private System.Windows.Forms.Button btnSwitchToVirtualDesktop;
        private System.Windows.Forms.Button btnCreateVirtualDesktop;
        private System.Windows.Forms.Button btnClose;
    }
}

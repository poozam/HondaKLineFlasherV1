namespace Honda_kline
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblBin = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBin = new System.Windows.Forms.TextBox();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.progressWrite = new System.Windows.Forms.ProgressBar();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(378, 154);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(483, 154);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(483, 85);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(377, 59);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(85, 59);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(72, 173);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(200, 100);
            this.panelTop.TabIndex = 5;
            // 
            // panelCenter
            // 
            this.panelCenter.Location = new System.Drawing.Point(206, 307);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(200, 100);
            this.panelCenter.TabIndex = 6;
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(354, 228);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(200, 100);
            this.panelBottom.TabIndex = 7;
            this.panelBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(29, 13);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(37, 16);
            this.lblCom.TabIndex = 8;
            this.lblCom.Text = "COM";
            // 
            // lblBin
            // 
            this.lblBin.AutoSize = true;
            this.lblBin.Location = new System.Drawing.Point(80, 12);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(29, 16);
            this.lblBin.TabIndex = 9;
            this.lblBin.Text = "BIN";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(130, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Ready";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(192, 11);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(62, 16);
            this.lblProgress.TabIndex = 11;
            this.lblProgress.Text = "Progress";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(262, 12);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(30, 16);
            this.lblLog.TabIndex = 12;
            this.lblLog.Text = "Log";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(331, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 16);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Honda K-Line Flasher";
            // 
            // txtBin
            // 
            this.txtBin.Location = new System.Drawing.Point(671, 269);
            this.txtBin.Name = "txtBin";
            this.txtBin.Size = new System.Drawing.Size(100, 22);
            this.txtBin.TabIndex = 14;
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(72, 88);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(121, 24);
            this.cmbCom.TabIndex = 16;
            // 
            // progressWrite
            // 
            this.progressWrite.Location = new System.Drawing.Point(12, 316);
            this.progressWrite.Name = "progressWrite";
            this.progressWrite.Size = new System.Drawing.Size(100, 23);
            this.progressWrite.TabIndex = 17;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(49, 345);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(100, 96);
            this.txtLog.TabIndex = 18;
            this.txtLog.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(947, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 139);
            this.panel4.TabIndex = 19;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1243, 564);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.progressWrite);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.txtBin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBin);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Honda K-Line Flasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblBin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBin;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.ProgressBar progressWrite;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel4;
    }
}


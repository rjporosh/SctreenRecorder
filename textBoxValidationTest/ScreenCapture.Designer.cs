namespace textBoxValidationTest
{
    partial class ScreenCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenCapture));
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnRecordScreen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.btnSysTray = new System.Windows.Forms.Button();
            this.notifyIcon1ScreenCapture = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Location = new System.Drawing.Point(794, 43);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(92, 61);
            this.btnScreenShot.TabIndex = 0;
            this.btnScreenShot.Text = "ScreenShot";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // btnRecordScreen
            // 
            this.btnRecordScreen.Location = new System.Drawing.Point(794, 110);
            this.btnRecordScreen.Name = "btnRecordScreen";
            this.btnRecordScreen.Size = new System.Drawing.Size(92, 61);
            this.btnRecordScreen.TabIndex = 0;
            this.btnRecordScreen.Text = "Record Screen";
            this.btnRecordScreen.UseVisualStyleBackColor = true;
            this.btnRecordScreen.Click += new System.EventHandler(this.btnRecordScreen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Location = new System.Drawing.Point(794, 177);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.Size = new System.Drawing.Size(92, 61);
            this.btnStopRecording.TabIndex = 0;
            this.btnStopRecording.Text = "Stop Recording";
            this.btnStopRecording.UseVisualStyleBackColor = true;
            this.btnStopRecording.Visible = false;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnSysTray
            // 
            this.btnSysTray.Location = new System.Drawing.Point(811, 264);
            this.btnSysTray.Name = "btnSysTray";
            this.btnSysTray.Size = new System.Drawing.Size(75, 63);
            this.btnSysTray.TabIndex = 2;
            this.btnSysTray.Text = "Goto System Tray Icon";
            this.btnSysTray.UseVisualStyleBackColor = true;
            this.btnSysTray.Click += new System.EventHandler(this.btnSysTray_Click);
            // 
            // notifyIcon1ScreenCapture
            // 
            this.notifyIcon1ScreenCapture.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1ScreenCapture.Icon")));
            this.notifyIcon1ScreenCapture.Text = "Screen Recorder";
            this.notifyIcon1ScreenCapture.Visible = true;
            this.notifyIcon1ScreenCapture.Click += new System.EventHandler(this.notifyIcon1ScreenCapture_Click);
            // 
            // ScreenCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 514);
            this.Controls.Add(this.btnSysTray);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnRecordScreen);
            this.Controls.Add(this.btnScreenShot);
            this.KeyPreview = true;
            this.Name = "ScreenCapture";
            this.Text = "ScreenCapture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenCapture_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScreenCapture_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnRecordScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStopRecording;
        private System.Windows.Forms.Button btnSysTray;
        private System.Windows.Forms.NotifyIcon notifyIcon1ScreenCapture;
    }
}
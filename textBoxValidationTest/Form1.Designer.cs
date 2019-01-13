namespace textBoxValidationTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNotify = new System.Windows.Forms.Button();
            this.notifyIcon1_SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameHint = new System.Windows.Forms.Label();
            this.AgeHint = new System.Windows.Forms.Label();
            this.CountryHint = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new textBoxValidationTest.CircularPictureBox();
            this.btnRegister = new textBoxValidationTest.CircularButton();
            this.btnLogin = new textBoxValidationTest.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(402, 55);
            this.btnNotify.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(155, 32);
            this.btnNotify.TabIndex = 0;
            this.btnNotify.Text = "Go to System tray";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // notifyIcon1_SystemTrayIcon
            // 
            this.notifyIcon1_SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1_SystemTrayIcon.Icon")));
            this.notifyIcon1_SystemTrayIcon.Text = "MyAppName";
            this.notifyIcon1_SystemTrayIcon.Visible = true;
            this.notifyIcon1_SystemTrayIcon.Click += new System.EventHandler(this.notifyIcon1_SystemTrayIcon_Click);
            this.notifyIcon1_SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_SystemTrayIcon_MouseDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 169);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 25);
            this.txtName.TabIndex = 1;
            this.txtName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 202);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Select a Type",
            "User",
            "Admin",
            "Student",
            "Teacher"});
            this.txtType.Location = new System.Drawing.Point(102, 245);
            this.txtType.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(120, 26);
            this.txtType.TabIndex = 2;
            this.txtType.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(53, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(26, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(47, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type  :";
            // 
            // NameHint
            // 
            this.NameHint.AutoSize = true;
            this.NameHint.Font = new System.Drawing.Font("Helvetica", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHint.ForeColor = System.Drawing.Color.Red;
            this.NameHint.Location = new System.Drawing.Point(303, 174);
            this.NameHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameHint.Name = "NameHint";
            this.NameHint.Size = new System.Drawing.Size(101, 15);
            this.NameHint.TabIndex = 3;
            this.NameHint.Text = "* Enter A Name";
            this.NameHint.Visible = false;
            // 
            // AgeHint
            // 
            this.AgeHint.AutoSize = true;
            this.AgeHint.Font = new System.Drawing.Font("Helvetica", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeHint.ForeColor = System.Drawing.Color.Red;
            this.AgeHint.Location = new System.Drawing.Point(303, 207);
            this.AgeHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgeHint.Name = "AgeHint";
            this.AgeHint.Size = new System.Drawing.Size(147, 15);
            this.AgeHint.TabIndex = 3;
            this.AgeHint.Text = "* Enter Your Password";
            this.AgeHint.Visible = false;
            // 
            // CountryHint
            // 
            this.CountryHint.AutoSize = true;
            this.CountryHint.Font = new System.Drawing.Font("Helvetica", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryHint.ForeColor = System.Drawing.Color.Red;
            this.CountryHint.Location = new System.Drawing.Point(230, 249);
            this.CountryHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountryHint.Name = "CountryHint";
            this.CountryHint.Size = new System.Drawing.Size(120, 15);
            this.CountryHint.TabIndex = 3;
            this.CountryHint.Text = "* Select Your Type";
            this.CountryHint.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 374);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueLT Pro 53 Ex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(10, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Available User\'s  :";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Noto Sans Disp Blk", 12F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(568, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 22);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(152, 23);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(125, 125);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 8;
            this.circularPictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(255, 276);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 86);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(113, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 80);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 471);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountryHint);
            this.Controls.Add(this.AgeHint);
            this.Controls.Add(this.NameHint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnNotify);
            this.Font = new System.Drawing.Font("Noto Sans Disp Cond", 9.749999F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon1_SystemTrayIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameHint;
        private System.Windows.Forms.Label AgeHint;
        private System.Windows.Forms.Label CountryHint;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClose;
        private CircularButton btnRegister;
        private CircularPictureBox circularPictureBox1;
        private CircularButton btnLogin;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.ComboBox txtType;
    }
}


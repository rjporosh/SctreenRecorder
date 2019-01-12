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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnTestLogin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(402, 26);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(155, 23);
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
            this.txtName.Location = new System.Drawing.Point(99, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // txtType
            // 
            this.txtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Select a Type",
            "User",
            "Admin",
            "Student",
            "Teacher"});
            this.txtType.Location = new System.Drawing.Point(99, 134);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(121, 21);
            this.txtType.TabIndex = 2;
            this.txtType.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type  :";
            // 
            // NameHint
            // 
            this.NameHint.AutoSize = true;
            this.NameHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHint.ForeColor = System.Drawing.Color.DarkRed;
            this.NameHint.Location = new System.Drawing.Point(291, 80);
            this.NameHint.Name = "NameHint";
            this.NameHint.Size = new System.Drawing.Size(80, 13);
            this.NameHint.TabIndex = 3;
            this.NameHint.Text = "* Enter A Name";
            this.NameHint.Visible = false;
            // 
            // AgeHint
            // 
            this.AgeHint.AutoSize = true;
            this.AgeHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeHint.ForeColor = System.Drawing.Color.DarkRed;
            this.AgeHint.Location = new System.Drawing.Point(291, 103);
            this.AgeHint.Name = "AgeHint";
            this.AgeHint.Size = new System.Drawing.Size(113, 13);
            this.AgeHint.TabIndex = 3;
            this.AgeHint.Text = "* Enter Your Password";
            this.AgeHint.Visible = false;
            // 
            // CountryHint
            // 
            this.CountryHint.AutoSize = true;
            this.CountryHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryHint.ForeColor = System.Drawing.Color.DarkRed;
            this.CountryHint.Location = new System.Drawing.Point(226, 137);
            this.CountryHint.Name = "CountryHint";
            this.CountryHint.Size = new System.Drawing.Size(96, 13);
            this.CountryHint.TabIndex = 3;
            this.CountryHint.Text = "* Select Your Type";
            this.CountryHint.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(402, 211);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Screen Capture Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnTestLogin
            // 
            this.btnTestLogin.Location = new System.Drawing.Point(99, 173);
            this.btnTestLogin.Name = "btnTestLogin";
            this.btnTestLogin.Size = new System.Drawing.Size(131, 39);
            this.btnTestLogin.TabIndex = 5;
            this.btnTestLogin.Text = "Test Login";
            this.btnTestLogin.UseVisualStyleBackColor = true;
            this.btnTestLogin.Click += new System.EventHandler(this.btnTestLogin_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Available User\'s  :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 327);
            this.Controls.Add(this.btnTestLogin);
            this.Controls.Add(this.btnNext);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon1_SystemTrayIcon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NameHint;
        private System.Windows.Forms.Label AgeHint;
        private System.Windows.Forms.Label CountryHint;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnTestLogin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}


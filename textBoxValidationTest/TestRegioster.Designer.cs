namespace textBoxValidationTest
{
    partial class TestRegioster
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
            this.picAvailable = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordHint = new System.Windows.Forms.Label();
            this.UserTypeHint = new System.Windows.Forms.Label();
            this.UserNameHint = new System.Windows.Forms.Label();
            this.FullNameHint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picAvailable);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PasswordHint);
            this.groupBox1.Controls.Add(this.UserTypeHint);
            this.groupBox1.Controls.Add(this.UserNameHint);
            this.groupBox1.Controls.Add(this.FullNameHint);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Location = new System.Drawing.Point(16, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(496, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // picAvailable
            // 
            this.picAvailable.Image = global::textBoxValidationTest.Properties.Resources.X;
            this.picAvailable.Location = new System.Drawing.Point(286, 79);
            this.picAvailable.Name = "picAvailable";
            this.picAvailable.Size = new System.Drawing.Size(38, 18);
            this.picAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvailable.TabIndex = 4;
            this.picAvailable.TabStop = false;
            this.picAvailable.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name :";
            // 
            // PasswordHint
            // 
            this.PasswordHint.AutoSize = true;
            this.PasswordHint.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordHint.ForeColor = System.Drawing.Color.DarkRed;
            this.PasswordHint.Location = new System.Drawing.Point(327, 122);
            this.PasswordHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordHint.Name = "PasswordHint";
            this.PasswordHint.Size = new System.Drawing.Size(157, 16);
            this.PasswordHint.TabIndex = 3;
            this.PasswordHint.Text = "* Enter Desired Password Here";
            this.PasswordHint.Visible = false;
            // 
            // UserTypeHint
            // 
            this.UserTypeHint.AutoSize = true;
            this.UserTypeHint.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeHint.ForeColor = System.Drawing.Color.DarkRed;
            this.UserTypeHint.Location = new System.Drawing.Point(288, 165);
            this.UserTypeHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserTypeHint.Name = "UserTypeHint";
            this.UserTypeHint.Size = new System.Drawing.Size(129, 16);
            this.UserTypeHint.TabIndex = 3;
            this.UserTypeHint.Text = "* Select Your Type Here";
            this.UserTypeHint.Visible = false;
            // 
            // UserNameHint
            // 
            this.UserNameHint.AutoSize = true;
            this.UserNameHint.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameHint.ForeColor = System.Drawing.Color.DarkRed;
            this.UserNameHint.Location = new System.Drawing.Point(327, 79);
            this.UserNameHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameHint.Name = "UserNameHint";
            this.UserNameHint.Size = new System.Drawing.Size(130, 16);
            this.UserNameHint.TabIndex = 3;
            this.UserNameHint.Text = "* Enter User Name Here";
            this.UserNameHint.Visible = false;
            // 
            // FullNameHint
            // 
            this.FullNameHint.AutoSize = true;
            this.FullNameHint.Font = new System.Drawing.Font("High Tower Text", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameHint.ForeColor = System.Drawing.Color.DarkRed;
            this.FullNameHint.Location = new System.Drawing.Point(327, 38);
            this.FullNameHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameHint.Name = "FullNameHint";
            this.FullNameHint.Size = new System.Drawing.Size(125, 16);
            this.FullNameHint.TabIndex = 3;
            this.FullNameHint.Text = "* Enter Full Name Here";
            this.FullNameHint.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Name :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 120);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(120, 76);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(204, 23);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(120, 35);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(204, 23);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // txtType
            // 
            this.txtType.FormattingEnabled = true;
            this.txtType.Items.AddRange(new object[] {
            "Select A Type",
            "User",
            "Admin",
            "Student",
            "Teacher"});
            this.txtType.Location = new System.Drawing.Point(120, 162);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(160, 23);
            this.txtType.TabIndex = 1;
            this.txtType.Leave += new System.EventHandler(this.txtType_Leave);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(255, 217);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(151, 48);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(62, 217);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(151, 48);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // TestRegioster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 352);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TestRegioster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestRegioster";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PasswordHint;
        private System.Windows.Forms.Label UserTypeHint;
        private System.Windows.Forms.Label UserNameHint;
        private System.Windows.Forms.Label FullNameHint;
        private System.Windows.Forms.PictureBox picAvailable;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtFullName;
        public System.Windows.Forms.ComboBox txtType;
    }
}
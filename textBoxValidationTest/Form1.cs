using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using DataAccessLayer;
using LinkAccessLayer;
using Microsoft.SqlServer.Server;
using static LinkAccessLayer.Information;

namespace textBoxValidationTest
{
    public partial class Form1 : Form
    {
        private DBEntities db;
        public Information info = new Information();
        public Operations opr = new Operations();
        public Form1()
        {
            InitializeComponent();
            txtType.SelectedIndex = 0;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1_SystemTrayIcon.ShowBalloonTip(1000,"Still Running.","Your App Still Running.",ToolTipIcon.Info);
        }

        private void notifyIcon1_SystemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (txtType.SelectedIndex < 1)
            {
                MessageBox.Show("You Must Select a Type");
                txtType.Select();
                //comboBox1.ForeColor = Color.Black;
                CountryHint.Visible = true;
            }
            else
            {
                CountryHint.Visible = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("You Must Provide a Name");
                txtName.Select();
                //textBox1.ForeColor = Color.Black;
                NameHint.Visible = true;
            }
            else
            {
                NameHint.Visible = false;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("You Must Provide your Password");
                txtPassword.Select();
                //textBox2.ForeColor = Color.Black;
                AgeHint.Visible = true;
            }
            else
            {
                AgeHint.Visible = false;
            }
        
        }

        private void notifyIcon1_SystemTrayIcon_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScreenCapture s= new ScreenCapture();
            s.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e) 
        {
            db = new DBEntities();
            List<tblTest> l = db.tblTests.ToList();
            comboBox1.DataSource = l;
            comboBox1.DisplayMember = "UserName";
            
        }
        public static Timer t;

        public void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            this.Hide();
            exit();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            Spash_Scereen s = new Spash_Scereen();
            s.Show();
            t.Tick += T_Tick;
        }

        void exit()
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            TestRegioster t = new TestRegioster();
            
            this.Hide();
            t.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
           //// DataAccess(f);
            
           // if (true)
           // {
           //     ScreenCapture s = new ScreenCapture();
           //     this.Hide();
           //     s.Show();
           // }
            info.UserName = txtName.Text;
            info.Password = txtPassword.Text;
            info.Type = txtType.Text;
            if(opr.login(info).Rows.Count>0)
            {
                this.Hide();
                ScreenCapture s =new ScreenCapture();
                MessageBox.Show("Login Success");
                s.Show();
            }
            else
            {
                MessageBox.Show("Login Failed.Register First.");
            }

        }
    }
}

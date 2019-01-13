using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Configuration;

namespace textBoxValidationTest
{
    public partial class TestRegioster : Form
    {
        private DBEntities db;
        private tblTest t = new tblTest();
        string con ="data source=MYLAPTOP\\SQLEXPRESS12;initial catalog=textBoxValidationTest;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public TestRegioster()
        {
            InitializeComponent();
            this.BackColor = Color.Lime;
            this.TransparencyKey = Color.Lime;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestRegioster t =new TestRegioster();
            Form1 f =new Form1();
            f.Show();
        }

        bool isAvailable()
        {
           
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["provider connection string"].ConnectionString;

            //SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringNameFromAppConfig"].ConnectionString);
            SqlDataAdapter sda =
                new SqlDataAdapter(
                    "Select * from tblTest Where UserName= '" + txtUserName.Text + "' And Type= '" + txtType.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool isNotEmpty()
        {
            if (txtFullName.Text != "" && txtPassword.Text != "" && txtUserName.Text != "" && txtType.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (isNotEmpty() && isAvailable())
            {
                t.FullName = txtFullName.Text;
                t.UserName = txtUserName.Text;
                t.Password = txtPassword.Text;
                t.Type = txtType.Text;
                using (db = new DBEntities())
                {
                    db.tblTests.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Registered Successfully");
                }
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }

        }

        private void txtFullName_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                FullNameHint.Visible = true;
                txtFullName.Select();
            }
            else
            {
                FullNameHint.Visible = false;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
               UserNameHint.Visible = true;
                picAvailable.Visible = false;
                txtUserName.Select();

            }
            else
            {
                UserNameHint.Visible = false;
                picAvailable.Visible = true;
                if (isAvailable())
                {
                    picAvailable.Image = textBoxValidationTest.Properties.Resources.Available;
                }
                else
                {
                    picAvailable.Image = textBoxValidationTest.Properties.Resources.X;
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                PasswordHint.Visible = true;
                txtPassword.Select();
            }
            else
            {
                PasswordHint.Visible = false;
            }
        }

        private void txtType_Leave(object sender, EventArgs e)
        {
            if (txtType.Text == "")
            {
                UserTypeHint.Visible = true;
                txtType.Select();
            }
            else
            {
                UserTypeHint.Visible = false;
            }
        }
    }
}

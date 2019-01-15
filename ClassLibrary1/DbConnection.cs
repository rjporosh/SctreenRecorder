using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

//using textBoxValidationTest;

namespace ClassLibrary1
{
    public class DbConnection 
    {
        //public DbConnection()
        //{
            
        //}

        public SqlConnection con = new SqlConnection("data source=MYLAPTOP\\SQLEXPRESS12;initial catalog=textBoxValidationTest;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public SqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsaffected;
        }

        public object ExeScalar(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            con.Close();
            return obj;
        }

        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }
        //    public static DBEntities db;
        //    //static Form1 f = new Form1();
        //    public static tblTest model = new tblTest();
        //    public static string con ="data source=MYLAPTOP\\SQLEXPRESS12;initial catalog=textBoxValidationTest;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

        //public DbConnection(Object o)
        //{
            
        //}

        //    public static bool LoginCheck(Object f)
        //    {
        //        string name = f.txtName.Text.Trim();
        //        string password = f.txtPassword.Text.Trim();
        //        string type = f.txtType.Text.Trim();
        //        SqlDataAdapter sda = new SqlDataAdapter("Select Type from tblMultipleLogin Where UserName= '" + name + "'and Password ='" + password + " ' and Type ='"+type+" ' ", con);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        if (dt.Rows.Count == 1)
        //        {
        //            MessageBox.Show("Login Successful");
        //            return true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Login Failed");
        //        }
        //    }
        //    public static bool isAvailable(object o)
        //    {

        //        //SqlConnection con = new SqlConnection();
        //        //con.ConnectionString = ConfigurationManager.ConnectionStrings["provider connection string"].ConnectionString;

        //        //SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStringNameFromAppConfig"].ConnectionString);
        //        object tr;
        //        tr=o;
        //        SqlDataAdapter sda =
        //            new SqlDataAdapter(
        //                "Select * from tblTest Where UserName= '" + tr.txtUserName.Text + "' And Type= '" + tr.txtType.Text + "'", con);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    public static bool isNotEmpty()
        //    {
        //        TestRegioster tt = new TestRegioster();
        //        if (tt.txtFullName.Text != "" && tt.txtPassword.Text != "" && tt.txtUserName.Text != "" && tt.txtType.Text != "")
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //    public static void Register(TestRegioster t)
        //    {
        //        //TestRegioster t = new TestRegioster();
        //        if (isNotEmpty() && isAvailable())
        //        {
        //            model.FullName = t.txtFullName.Text;
        //            model.UserName = t.txtUserName.Text;
        //            model.Password = t.txtPassword.Text;
        //            model.Type = t.txtType.Text;
        //            using (db = new DBEntities())
        //            {
        //                db.tblTests.Add(model);
        //                db.SaveChanges();
        //                MessageBox.Show("Registered Successfully");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Registration Failed");
        //        }
        //    }
    }
}

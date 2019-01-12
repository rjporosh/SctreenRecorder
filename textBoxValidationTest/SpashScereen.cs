using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textBoxValidationTest
{
    public partial class Spash_Scereen : Form
    {
        public Spash_Scereen()
        {
            InitializeComponent();
        }

       public static Timer t;

        public  void Spash_Scereen_Shown(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 2000;
            t.Start();
            t.Tick += T_Tick;
        }

        public void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Form1 f= new Form1();
            f.Show();
            this.Hide();
        }
    }
}

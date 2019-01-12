using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Timers;

namespace textBoxValidationTest
{
    public partial class ScreenCapture : Form
    {
        public ScreenCapture()
        {
            InitializeComponent();
        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
           ScreenShot();
        }

        void ScreenShot()
        {
            Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
            pictureBox1.Image = b;
            b.Save("C:\\Users\\Porosh Prince\\Pictures\\Saved Pictures\\ScreenShotPoroshApp.jpg");
        }
        private bool record = false;

        void recording()
        {
            while (record)
            {
                Bitmap b = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                Graphics g = Graphics.FromImage(b);
                g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
                pictureBox1.Image = b;
                // b.Save("C:\\Users\\Porosh Prince\\Pictures\\Saved Pictures\\ScreenRecPoroshApp.mp4");
            }
        }

        void ScreenRecording()
        {
            btnStopRecording.Visible = true;
            record = true;
            Thread t = new Thread(recording);
            t.Start();
        }
        private void btnRecordScreen_Click(object sender, EventArgs e)
        {
            ScreenRecording();

        }

        void StopRecording()
        {
            btnStopRecording.Visible = false;
            record = false;
        }
        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void ScreenCapture_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenCapture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "A")
            {
                ScreenShot();
                MessageBox.Show("ScreenShot Saved");
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                ScreenRecording();
            }
            else if (e.Control && e.KeyCode ==Keys.S)
            {
                StopRecording();
            }
        }

        private void btnSysTray_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1ScreenCapture.ShowBalloonTip(1000,"ScreenRecorder Still Running.","Your RjPorosh App Still Running.",ToolTipIcon.Info);

        }

        private void notifyIcon1ScreenCapture_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
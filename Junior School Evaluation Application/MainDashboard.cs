using Junior_School_Evaluation_Application.Students.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Junior_School_Evaluation_Application
{
    public partial class MainDashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        bool sidebarExpand;
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsList list = new StudentsList();
            list.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panel4.Width -= 10;
                if(panel4.Width == panel4.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panel4.Width += 10;
                if(panel4.Width == panel4.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

        }
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void navButton2_Click(object sender, EventArgs e)
        {
            if (this.bodyPanel.Controls.Count > 0)
            {
                foreach (Control control in this.bodyPanel.Controls)
                {
                    this.bodyPanel.Controls.Remove(control);
                }

            }
            this.navButton2.BackColor = Color.FromArgb(105, 65, 198);
            StudentsList frm = new StudentsList() { TopLevel = false, TopMost = true, WindowState = FormWindowState.Maximized, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right };
            this.bodyPanel.Controls.Add(frm);

            frm.Show();
        }
    }
}

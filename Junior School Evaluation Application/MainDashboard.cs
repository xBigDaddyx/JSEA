using Junior_School_Evaluation_Application.Students.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class MainDashboard : Form
    {
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
            StudentsList frm = new StudentsList() { TopLevel = false, TopMost = true };
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}

using Junior_School_Evaluation_Application.Classes.Services;
using Junior_School_Evaluation_Application.Students.Services;
using System;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class MainDashboard : Form
    {
        private StudentsList studentsList = null;
        private ClassesList classesList = null;

        public MainDashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Close();
            this.Dispose();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (studentsList == null || studentsList.IsDisposed)
            {
                studentsList = new StudentsList();
            }

            studentsList.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classesList == null || classesList.IsDisposed)
            {
                classesList = new ClassesList();
            }

            classesList.Show();
        }
    }
}

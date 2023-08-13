using System;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Students.Services
{
    public partial class StudentsList : Form
    {
        private StudentsService services;
        public StudentsList()
        {
            InitializeComponent();
            services = new StudentsService();
        }
         
        private void StudentsListInterfaces_Load(object sender, EventArgs e)
        {
            services.bindData(list_students);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            services.addNewStudent(list_students);
        }
    }
}

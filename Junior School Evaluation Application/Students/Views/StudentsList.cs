using Junior_School_Evaluation_Application.Students.Models;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Students.Services
{
    public partial class StudentsList : Form
    {
        private StudentsService services;

        private StudentsDTO selectedStudent;

        public StudentsList()
        {
            InitializeComponent();
            services = new StudentsService();
            selectedStudent = new StudentsDTO();

            btn_update.Visible = false;
            btn_delete.Visible = false;
        }
         
        private void StudentsListInterfaces_Load(object sender, EventArgs e)
        {
            services.bindData(dgrid_list_student);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            services.addNewStudent(dgrid_list_student);
        }

        private void dgrid_list_student_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedStudent.id = dgrid_list_student.CurrentRow.Cells[0].Value.ToString();
            selectedStudent.name = dgrid_list_student.CurrentRow.Cells[1].Value.ToString();

            btn_update.Visible = true;
            btn_delete.Visible = true;

            lbl_selected.Text = selectedStudent.name;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            services.editStudent(dgrid_list_student, selectedStudent);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            services.deleteStudent(dgrid_list_student, selectedStudent);
        }
    }
}

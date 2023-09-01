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
            this.dgrid_list_student.ColumnHeadersDefaultCellStyle.BackColor = Colors.ColumnHeadersBg;
            this.dgrid_list_student.ColumnHeadersDefaultCellStyle.SelectionBackColor = Colors.ColumnHeadersSelectionBackColor;
            this.dgrid_list_student.RowsDefaultCellStyle.BackColor = Colors.RowsDefaultBg;
            this.dgrid_list_student.RowsDefaultCellStyle.ForeColor = Colors.RowsDefaultFore;
            this.dgrid_list_student.RowsDefaultCellStyle.SelectionBackColor = Colors.RowsDefaultSelectionBackColor;
            this.dgrid_list_student.RowsDefaultCellStyle.SelectionForeColor = Colors.RowsDefaultSelectionForeColor;
                
            this.dgrid_list_student.AlternatingRowsDefaultCellStyle.BackColor = Colors.AlternatingDefaultBg;
            this.dgrid_list_student.AlternatingRowsDefaultCellStyle.ForeColor = Colors.AlternatingDefaultFore;
            this.dgrid_list_student.AlternatingRowsDefaultCellStyle.SelectionBackColor = Colors.AlternatingDefaultSelectionBackColor;
            this.dgrid_list_student.AlternatingRowsDefaultCellStyle.SelectionForeColor = Colors.AlternatingDefaultSelectionForeColor;
                 
            this.dgrid_list_student.GridColor = Colors.GridColor;
            this.dgrid_list_student.BackgroundColor = Colors.mainBg;
            this.groupBox1.BackColor = Colors.mainBg;
            this.groupBox1.ForeColor = Colors.mainFore;

            ThemeUtility.ApplyButtonTheme(btn_update, "warning");
            ThemeUtility.ApplyButtonTheme(btn_delete, "danger");
            ThemeUtility.ApplyButtonTheme(btn_new, "success");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            services.addNewStudent(dgrid_list_student);
        }

        private void dgrid_list_student_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedStudent.id = dgrid_list_student.CurrentRow.Cells[DatabaseUtility.studentCrudId].Value.ToString();
            selectedStudent.name = dgrid_list_student.CurrentRow.Cells[DatabaseUtility.studentCrudName].Value.ToString();

            btn_update.Visible = true;
            btn_delete.Visible = true;

            lbl_selected.Text = selectedStudent.name;
        }

        private void dgrid_list_student_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            selectedStudent.id = "";
            selectedStudent.name = "";

            btn_update.Visible = false;
            btn_delete.Visible = false;

            lbl_selected.Text = "";
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

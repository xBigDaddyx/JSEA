using Junior_School_Evaluation_Application.Classes.Models;
using Junior_School_Evaluation_Application.Classes.Services;
using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Classes.Services
{
    public partial class ClassesList : Form
    {
        private ClassesService services;

        private ClassesDTO selectedClasses;

        public ClassesList()
        {
            InitializeComponent();

            services = new ClassesService();
            selectedClasses = new ClassesDTO();

            btn_update.Visible = false;
            btn_delete.Visible = false;
        }
         
        private void ClassesListInterfaces_Load(object sender, EventArgs e)
        { 
            services.bindData(dgrid_list);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            services.addNewClasses(dgrid_list);
        }

        private void dgrid_list_student_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedClasses.id = dgrid_list.CurrentRow.Cells[DatabaseUtility.classesCrudId].Value.ToString();
            selectedClasses.name = dgrid_list.CurrentRow.Cells[DatabaseUtility.classesCrudName].Value.ToString();

            btn_update.Visible = true;
            btn_delete.Visible = true;

            lbl_selected.Text = selectedClasses.name;
        }

        private void dgrid_list_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            selectedClasses.id = "";
            selectedClasses.name = "";

            btn_update.Visible = false;
            btn_delete.Visible = false;

            lbl_selected.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            services.editClasses(dgrid_list, selectedClasses);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            services.deleteClasses(dgrid_list, selectedClasses);
        }

        private void dgrid_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

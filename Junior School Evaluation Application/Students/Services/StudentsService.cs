using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Students.Services
{
    public class StudentsService
    { 
        public StudentsService()
        { 

        }
         
        public void bindData(DataGridView gridView)
        {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getViewStudentQuery(), connection);

                    DataTable dTable = new DataTable();

                    OleDbDataAdapter sqlAdpt = new OleDbDataAdapter(command);

                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();
                    sqlAdpt.Fill(dTable);
                    connection.Close();
                    gridView.DataSource = dTable;
                }
                catch (Exception ex)
                {
                    //:: menampilkan berupa pesan error
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        public void addNewStudent(DataGridView gridView)
        {
            StudentsCRUD studentsCRUDInterfaces = new StudentsCRUD(message =>
            {
                    this.bindData(gridView);
                    this.showMessageBox("Sukses", message);
            });
            studentsCRUDInterfaces.Show(); 
        }

         // Custom Message Box -----------------------------------------------------------
        public void showMessageBox(string title, string msg)
        {
            var customMessageBox = new CustomMessageBox(msg, title);
            customMessageBox.StartPosition = FormStartPosition.CenterParent;
            customMessageBox.Show(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Students.Services
{
    public partial class StudentsListInterfaces : Form
    {
        public StudentsListInterfaces()
        {
            InitializeComponent();
        }

        public void bindData()
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
                     
                    list_students.DataSource = dTable;
                }
                catch (Exception ex)
                {
                    //:: menampilkan berupa pesan error
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void StudentsListInterfaces_Load(object sender, EventArgs e)
        {
            bindData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            StudentsCRUDInterfaces studentsCRUDInterfaces = new StudentsCRUDInterfaces();
            studentsCRUDInterfaces.PerformActionWithCallback(message => Console.WriteLine("Received message: " + message));
            studentsCRUDInterfaces.ShowDialog();
        }
    }
}

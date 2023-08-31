using Junior_School_Evaluation_Application.Auth.Models;
using Junior_School_Evaluation_Application.Auth.Views;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Auth.Services
{
    public class TeacherRegisterService
    {
        private Teachers model;
        private Register view;

        private OleDbConnection connection;

        public TeacherRegisterService(Teachers model, string connectionString)
        {
            this.model = model;
            connection = new OleDbConnection(connectionString);
        }
        public void Initialize(Register view)
        {
            this.view = view;

        }
        public bool CheckRegistered()
        {
            int row;
            try
            {
                connection.Open();
                string query = DatabaseUtility.getRegisteredQuery();
                OleDbCommand command = new OleDbCommand(query, connection);
                row = (int)command.ExecuteScalar();
                connection.Close();
                if (row > 0)
                {
                    Console.WriteLine("true");
                    return true;
                }
                else
                {
                    Console.WriteLine("false");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
                connection.Close();
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        private bool RegisterProcess(string id, string nama, string password, string telepon = null, string alamat = null)
        {
            int row;
            try
            {
                connection.Open();
                string query = DatabaseUtility.getRegisterQuery();
                OleDbCommand command = new OleDbCommand(query, connection);
                string hashedPassword = DatabaseUtility.HashPassword(password);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@password", hashedPassword);
                command.Parameters.AddWithValue("@telepon", telepon);
                command.Parameters.AddWithValue("@alamat", alamat);

                row = command.ExecuteNonQuery();
                connection.Close();
                if (row > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }
        }
        public void Register(string id, string nama, string password, string telepon = null, string alamat = null)
        {
            if (RegisterProcess(id, nama, password, telepon, alamat))
            {
                MessageBox.Show("Register Berhasil, silahkan login dengan akun anda.");
               
                view.Hide();
                TeacherServices teacherService = new TeacherServices(model, DatabaseUtility.getConnectionString());
                Login loginForm = new Login(teacherService);
                loginForm.Show();
            }
        }
    }
}

using Junior_School_Evaluation_Application.Auth.Models;
using Junior_School_Evaluation_Application.Auth.Views;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Auth.Services
{
    public class TeacherServices
    {
        private Teachers model;
        private Login view;
        private OleDbConnection connection;

        public TeacherServices(Teachers model, string connectionString)
        {
            this.model = model;
            connection = new OleDbConnection(connectionString);
        }
        public void Initialize(Login view)
        {
            this.view = view;
        }
        public void Login(string enteredUsername, string enteredPassword)
        {
            //:: memanggil metode VerifyLogin untuk verifikasi login
            if (VerifyLogin(enteredUsername, enteredPassword))
            {
                MessageBox.Show("Login Berhasil, Selamat datang.");

            }
            else
            {
                MessageBox.Show("Login gagal, silahkan coba lagi.");
            }
        }

        private bool VerifyLogin(string enteredUsername, string enteredPassword)
        {

            try
            {
                //:: state oledbconnection harus di buka dulu dengan methode Open()
                connection.Open();
                //:: memanggil metode GetLoginQuery untuk mengambil password dengan parameter username
                string query = DatabaseUtility.GetLoginQuery();
                //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                OleDbCommand command = new OleDbCommand(query, connection);
                //:: menentukan parameter untuk @Username dan value ambil dari input textbox username
                command.Parameters.AddWithValue("@Username", enteredUsername);

                string encryptedPassword = (string)command.ExecuteScalar();
                connection.Close();
                //:: logic untuk login
                //:: jika password yang terenkripsi itu tidak kosong dan sama dengan password yang di input dari field username maka true
                if (enteredPassword != null && encryptedPassword == DatabaseUtility.HashPassword(enteredPassword)) // contoh manggil fungsi hashpassword
                {
                    return true; //:: kata sandi cocok

                }
                else
                {
                    return false; //:: kata sandi tidak cocok
                }

            }

            catch (Exception ex)
            {
                //:: menampilkan berupa pesan error
                MessageBox.Show("Error : " + ex.Message);
                return false;
            }

        }
    }
}

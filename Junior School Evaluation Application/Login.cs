using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private bool VerifyLogin(string enteredUsername, string enteredPassword) {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT "+DatabaseUtility.AuthPassword+" FROM "+DatabaseUtility.AuthTable+" where "+DatabaseUtility.AuthUsername+" = @Username";
                    OleDbCommand command = new OleDbCommand(query,connection);
                    command.Parameters.AddWithValue("@Username", enteredUsername); //:: menentukan parameter untuk @Username dan value ambil dari input textbox username
                    string encryptedPassword = (string)command.ExecuteScalar();

                    //:: logic untuk login
                    if (encryptedPassword != null && encryptedPassword == DatabaseUtility.HashPassword(enteredPassword) ){ 
                    return true; //:: kata sandi cocok
                    }
                    else
                    {
                        return false; //:: kata sandi tidak cocok
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                    return false;
                }
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            string enteredUsername = txt_username.Text;
            string enteredPassword = txt_password.Text;

            if (VerifyLogin(enteredUsername, enteredPassword))
            {
                MessageBox.Show("Login Berhasil, Selamat datang.");
            }
            else
            {
                MessageBox.Show("Login gagal, silahkan coba lagi.");
            }
        }
        private bool ValidateInput()
        {
            if(string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Mohon untuk di isi kolom username dan password anda.");
                return false;
            }
            return true;
        }
        

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

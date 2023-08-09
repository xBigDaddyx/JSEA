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
        const string username = "faisal";
        const string password = "telo";
        public Login()
        {
            InitializeComponent();
        }
        private bool VerifyLogin(string enteredUsername, string enteredPassword) {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    
                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();
                    //:: memanggil metode GetLoginQuery untuk mengambil password dengan parameter username
                    //string query = "SELECT COUNT(*) FROM Teachers WHERE Teacher_name = @Username AND Teacher_password = @Password";
                    string query = DatabaseUtility.GetLoginQuery();
                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(query,connection);
                    //:: menentukan parameter untuk @Username dan value ambil dari input textbox username
                    command.Parameters.AddWithValue("@Username", enteredUsername);
                    //command.Parameters.AddWithValue("@Password", enteredPassword);

                    //int count = (int)command.ExecuteScalar();

                    string encryptedPassword = (string)command.ExecuteScalar();

                    //:: logic untuk login
                    //:: jika password yang terenkripsi itu tidak kosong dan sama dengan password yang di input dari field username maka true
                    if (enteredPassword != null && encryptedPassword == DatabaseUtility.HashPassword(enteredPassword) ){ 
                    //if (count > 0)
                    
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
        private void btn_login_Click(object sender, EventArgs e)
        {
            //:: memanggil metode ValidateInput untuk melakukan validasi sebelum verifikasi
            if (!ValidateInput()) //:: jika ValidateInput hasilnya false
            {
                return; //:: maka return null atau prosess login berhenti di sini
            }

            //:: variable baru untuk data dari field username dan password (menghindari SQL Injection)
            string enteredUsername = txt_username.Text;
            string enteredPassword = txt_password.Text;

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
        private bool ValidateInput()
        {
            //:: logic jika field username dan password itu kosong atau ada spasi maka return false dan menampilkan messagebox
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

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                //:: memanggil metode ValidateInput untuk melakukan validasi sebelum verifikasi
                if (!ValidateInput()) //:: jika ValidateInput hasilnya false
                {
                    return; //:: maka return null atau prosess login berhenti di sini
                }

                //:: variable baru untuk data dari field username dan password (menghindari SQL Injection)
                string enteredUsername = txt_username.Text;
                string enteredPassword = txt_password.Text;

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
           
        }
    }
}

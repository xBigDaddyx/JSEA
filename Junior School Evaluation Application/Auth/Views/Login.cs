using Junior_School_Evaluation_Application.Auth.Services;
using System;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Auth.Views
{
    public partial class Login : Form
    {
        private TeacherServices services;
        public Login(TeacherServices services)
        {
            InitializeComponent();
            this.services = services;
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


            services.Login(enteredUsername, enteredPassword);
        }
        private bool ValidateInput()
        {
            //:: logic jika field username dan password itu kosong atau ada spasi maka return false dan menampilkan messagebox
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Mohon untuk di isi kolom username dan password anda.");
                return false;
            }
            return true;
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //:: memanggil metode ValidateInput untuk melakukan validasi sebelum verifikasi
                if (!ValidateInput()) //:: jika ValidateInput hasilnya false
                {
                    return; //:: maka return null atau prosess login berhenti di sini
                }

                //:: variable baru untuk data dari field username dan password (menghindari SQL Injection)
                string enteredUsername = txt_username.Text;
                string enteredPassword = txt_password.Text;

                services.Login(enteredUsername, enteredPassword);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

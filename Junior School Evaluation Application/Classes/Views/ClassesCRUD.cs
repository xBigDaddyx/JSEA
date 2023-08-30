using Junior_School_Evaluation_Application.Classes.Models;
using Junior_School_Evaluation_Application.Classes.Services;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class ClassesCRUD : Form
    {
        private bool updateMode = false;

        private ClassesService services;

        private Action<string> _callback;

        public ClassesCRUD(Action<string> callback)
        {
            InitializeComponent();

            services = new ClassesService();
            _callback = callback;
        }

        public void setEditData(ClassesDTO targetClasses)
        {
            updateMode = true;

            txt_id_student.Text = targetClasses.id;
            txt_name.Text = targetClasses.name;  
            numb_age.Text = targetClasses.capacity;

            txt_id_student.Enabled = false;
        }

        private bool validateInput()
        {
            //:: logic jika field username dan password itu kosong atau ada spasi maka return false dan menampilkan messagebox
            if (string.IsNullOrWhiteSpace(txt_id_student.Text) || string.IsNullOrWhiteSpace(txt_id_student.Text))
            {
                services.showMessageBox("Perhatian!", "Pastikan anda mengisi setiap kolom yang wajib");
                return false;
            }
            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
         
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (!validateInput())
            {
                return;
            }

            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    Classes.Models.ClassesDTO newClasses = new Classes.Models.ClassesDTO();
                    newClasses.id = txt_id_student.Text;
                    newClasses.name = txt_name.Text; 
                    newClasses.capacity = numb_age.Text;
                     
                    OleDbCommand command;
                    if (updateMode)
                    {
                        command = new OleDbCommand(DatabaseUtility.getUpdateClassesQuery(newClasses), connection);
                    }
                    else
                    {
                        command = new OleDbCommand(DatabaseUtility.getCreateClassesQuery(newClasses), connection);
                    }

                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open(); 
                    command.ExecuteNonQuery(); 
                    connection.Close();

                    this.Close();
                    this.Dispose();

                    _callback?.Invoke(updateMode ? "Data siswa berhasil diperbarui!" : "Siswa baru berhasil ditambahkan!");
                }
                catch (Exception ex)
                {
                    //:: menampilkan berupa pesan error
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

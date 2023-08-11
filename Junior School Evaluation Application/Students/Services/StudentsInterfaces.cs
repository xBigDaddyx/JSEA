using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class StudentsInterfaces : Form
    {
        Students.Models.StudentsDTO newStudent = new Students.Models.StudentsDTO();

        public StudentsInterfaces()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            newStudent.name = txt_name.Text;
            newStudent.gender = txt_name.Text;
            newStudent.id = txt_name.Text;
            newStudent.bornPlace = txt_name.Text;
            newStudent.bornDate = txt_name.Text;
            newStudent.religion = txt_name.Text;
            newStudent.nation = txt_name.Text;
            newStudent.address = txt_name.Text;
            newStudent.livingWith = txt_name.Text;
            newStudent.bornOrder = txt_name.Text;
            newStudent.age = txt_name.Text;
            newStudent.phoneNumber = txt_name.Text;

            newStudent.fatherName = txt_name.Text;
            newStudent.fatherId = txt_name.Text;
            newStudent.fatherYearOfBirth = txt_name.Text;
            newStudent.fatherLastEducation = txt_name.Text;
            newStudent.fatherJob = txt_name.Text;

            newStudent.motherName = txt_name.Text;
            newStudent.motherId = txt_name.Text;
            newStudent.motherYearOfBirth = txt_name.Text;
            newStudent.motherLastEducation = txt_name.Text;
            newStudent.motherJob = txt_name.Text;

            newStudent.classGroup = txt_name.Text;

            newStudent.tall = txt_name.Text;
            newStudent.weight = txt_name.Text;
            newStudent.range = txt_name.Text;
            newStudent.brotherSisterCount = txt_name.Text;

            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();

                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getCreateStudentQuery(newStudent), connection);

                    MessageBox.Show("Success create new Student!");
                }
                catch (Exception ex)
                {
                    //:: menampilkan berupa pesan error
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }
    }
}

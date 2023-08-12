using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class StudentsCRUDInterfaces : Form
    {
        public StudentsCRUDInterfaces()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            Students.Models.StudentsDTO newStudent = new Students.Models.StudentsDTO(); 
            newStudent.name = txt_name.Text;
            newStudent.gender = combo_gender.Text;
            newStudent.id = txt_id_student.Text;
            newStudent.bornPlace = txt_born_place.Text;
            newStudent.bornDate = date_picker_born_date.Text;
            newStudent.religion = combo_religion.Text;
            newStudent.nation = txt_nation.Text;
            newStudent.address = txt_address.Text;
            newStudent.livingWith = txt_living_with.Text;
            newStudent.bornOrder = numb_born_order.Text;
            newStudent.age = numb_age.Text;
            newStudent.phoneNumber = txt_phone.Text;

            newStudent.fatherName = txt_father_name.Text;
            newStudent.fatherId = txt_father_id.Text;
            newStudent.fatherYearOfBirth = year_of_father_born.Text;
            newStudent.fatherLastEducation = txt_father_education.Text;
            newStudent.fatherJob = txt_father_job.Text;

            newStudent.motherName = txt_mother_name.Text;
            newStudent.motherId = txt_mother_id.Text;
            newStudent.motherYearOfBirth = year_of_mother_born.Text;
            newStudent.motherLastEducation = txt_mother_education.Text;
            newStudent.motherJob = txt_mother_job.Text;

            newStudent.classGroup = combo_class.Text;

            newStudent.tall = combo_tall_type.Text;
            newStudent.weight = numb_weight.Text;
            newStudent.range = numb_range.Text;
            newStudent.brotherSisterCount = numb_brother_sister.Text;

            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();

                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getCreateStudentQuery(newStudent), connection);

                    command.Parameters.AddWithValue("@1", newStudent.id);
                    command.Parameters.AddWithValue("@2", newStudent.name);
                    command.Parameters.AddWithValue("@3", newStudent.bornPlace);
                    command.Parameters.AddWithValue("@4", newStudent.address);
                    command.Parameters.AddWithValue("@5", newStudent.phoneNumber);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Success create new Student!");

                    this.Close();
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

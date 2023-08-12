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

        // Fungsi yang menerima Action (callback) sebagai parameter
        public void PerformActionWithCallback(Action<string> callback)
        {
            // Lakukan sesuatu di dalam fungsi ini
            Console.WriteLine("Performing action...");

            // Panggil callback dengan pesan
            callback("Action completed!");
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
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

                    newStudent.tall = num_tall.Text;
                    newStudent.weight = numb_weight.Text;
                    newStudent.range = numb_range.Text;
                    newStudent.brotherSisterCount = numb_brother_sister.Text;

                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getCreateStudentQuery(newStudent), connection);

                    command.Parameters.AddWithValue("@param1", newStudent.name);
                    command.Parameters.AddWithValue("@param2", newStudent.gender);
                    command.Parameters.AddWithValue("@param3", newStudent.id);
                    command.Parameters.AddWithValue("@param4", newStudent.bornPlace);
                    command.Parameters.AddWithValue("@param5", newStudent.bornDate);
                    command.Parameters.AddWithValue("@param6", newStudent.religion);
                    command.Parameters.AddWithValue("@param7", newStudent.nation);
                    command.Parameters.AddWithValue("@param8", newStudent.address);
                    command.Parameters.AddWithValue("@param9", newStudent.livingWith);
                    command.Parameters.AddWithValue("@param10", int.Parse(newStudent.bornOrder));
                    command.Parameters.AddWithValue("@param11", int.Parse(newStudent.age));
                    command.Parameters.AddWithValue("@param12", newStudent.phoneNumber);

                    command.Parameters.AddWithValue("@param13", newStudent.fatherName);
                    command.Parameters.AddWithValue("@param14", newStudent.fatherId);
                    command.Parameters.AddWithValue("@param15", newStudent.fatherYearOfBirth);
                    command.Parameters.AddWithValue("@param16", newStudent.fatherLastEducation);
                    command.Parameters.AddWithValue("@param17", newStudent.fatherJob);

                    command.Parameters.AddWithValue("@param18", newStudent.motherName);
                    command.Parameters.AddWithValue("@param19", newStudent.motherId);
                    command.Parameters.AddWithValue("@param20", newStudent.motherYearOfBirth);
                    command.Parameters.AddWithValue("@param21", newStudent.motherLastEducation);
                    command.Parameters.AddWithValue("@param22", newStudent.motherJob);

                    command.Parameters.AddWithValue("@param23", int.Parse(newStudent.tall));
                    command.Parameters.AddWithValue("@param24", int.Parse(newStudent.weight));
                    command.Parameters.AddWithValue("@param25", newStudent.range);
                    command.Parameters.AddWithValue("@param26", int.Parse(newStudent.brotherSisterCount));

                    command.Parameters.AddWithValue("@param27", newStudent.classGroup);

                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open(); 
                    command.ExecuteNonQuery(); 
                    connection.Close();

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

using Junior_School_Evaluation_Application.Students.Services;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class StudentsCRUD : Form
    {
        private StudentsService services;

        private Action<string> _callback;

        public StudentsCRUD(Action<string> callback)
        {
            InitializeComponent();

            services = new StudentsService();
            _callback = callback;
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
                      
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getCreateStudentQuery(newStudent), connection);

                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open(); 
                    command.ExecuteNonQuery(); 
                    connection.Close();

                    this.Close();
                    this.Dispose();

                    _callback?.Invoke("Siswa baru berhasil ditambahkan!");
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

using Junior_School_Evaluation_Application.Students.Models;
using Junior_School_Evaluation_Application.Students.Services;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class StudentsCRUD : Form
    {
        private bool updateMode = false;

        private StudentsService services;

        private Action<string> _callback;

        public StudentsCRUD(Action<string> callback)
        {
            InitializeComponent();

            services = new StudentsService();
            _callback = callback;
        }

        public void setEditData(StudentsDTO targetStudent)
        {
            updateMode = true;

            txt_name.Text = targetStudent.name;
            combo_gender.Text = targetStudent.gender;
            txt_id_student.Text = targetStudent.id;
            txt_born_place.Text = targetStudent.bornPlace;
            date_picker_born_date.Text = targetStudent.bornDate;
            combo_religion.Text = targetStudent.religion;
            txt_nation.Text = targetStudent.nation;
            txt_address.Text = targetStudent.address;
            txt_living_with.Text = targetStudent.livingWith;
            numb_born_order.Text = targetStudent.bornOrder;
            numb_age.Text = targetStudent.age;
            txt_phone.Text = targetStudent.phoneNumber;
            
            txt_father_name.Text = targetStudent.fatherName;
            txt_father_id.Text = targetStudent.fatherId;
            year_of_father_born.Text = targetStudent.fatherYearOfBirth; 
            txt_father_education.Text = targetStudent.fatherLastEducation;
            txt_father_job.Text = targetStudent.fatherJob;

            txt_mother_name.Text = targetStudent.motherName;
            txt_mother_id.Text = targetStudent.motherId;
            year_of_mother_born.Text = targetStudent.motherYearOfBirth;
            txt_mother_education.Text = targetStudent.motherLastEducation;
            txt_mother_job.Text = targetStudent.motherJob;

            combo_class.Text = targetStudent.classGroup;

            num_tall.Text = targetStudent.tall;
            numb_weight.Text = targetStudent.weight;
            numb_range.Text = targetStudent.range;
            numb_brother_sister.Text = targetStudent.brotherSisterCount;

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

                    OleDbCommand command;

                    if (updateMode)
                    {
                        command = new OleDbCommand(DatabaseUtility.getUpdateStudentQuery(newStudent), connection);
                    }
                    else
                    {
                        command = new OleDbCommand(DatabaseUtility.getCreateStudentQuery(newStudent), connection);
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

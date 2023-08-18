using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Junior_School_Evaluation_Application.Students.Models;
using System.Data.SqlClient;

namespace Junior_School_Evaluation_Application.Students.Services
{
    public class StudentsService
    { 
        public StudentsService()
        { 

        }
         
        public void bindData(DataGridView gridView)
        {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getViewStudentQuery(), connection);

                    DataTable dTable = new DataTable();

                    OleDbDataAdapter sqlAdpt = new OleDbDataAdapter(command);

                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();

                    sqlAdpt.Fill(dTable);
                     
                    dTable.Columns[1].ColumnName = "Nama";
                    dTable.Columns[2].ColumnName = "No. HP";
                    dTable.Columns[3].ColumnName = "Kelas";

                    connection.Close();
                    gridView.DataSource = dTable;
                }
                catch (Exception ex)
                {
                    //:: menampilkan berupa pesan error
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        public void bindDataForId(string id, StudentsDTO targetContainer)
        {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getViewStudentSpesificQuery(id), connection);
                      
                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        targetContainer.id = reader[DatabaseUtility.studentCrudId].ToString();
                        targetContainer.name = reader[DatabaseUtility.studentCrudName].ToString();
                        targetContainer.gender = reader[DatabaseUtility.studentCrudGender].ToString();
                        targetContainer.bornPlace = reader[DatabaseUtility.studentCrudBirthPlace].ToString();
                        targetContainer.bornDate = reader[DatabaseUtility.studentCrudBirthDate].ToString();
                        targetContainer.religion = reader[DatabaseUtility.studentCrudReligion].ToString();
                        targetContainer.nation = reader[DatabaseUtility.studentCrudNation].ToString();
                        targetContainer.address = reader[DatabaseUtility.studentCrudAddress].ToString();
                        targetContainer.livingWith = reader[DatabaseUtility.studentCrudHouseWith].ToString();
                        targetContainer.bornOrder = reader[DatabaseUtility.studentCrudBirthOrder].ToString();
                        targetContainer.age = reader[DatabaseUtility.studentCrudAge].ToString();
                        targetContainer.phoneNumber = reader[DatabaseUtility.studentCrudPhoneNumber].ToString();

                        targetContainer.fatherName = reader[DatabaseUtility.fatherCrudName].ToString();
                        targetContainer.fatherYearOfBirth = reader[DatabaseUtility.fatherCrudYearOfBirth].ToString();
                        targetContainer.fatherId = reader[DatabaseUtility.fatherCrudId].ToString();
                        targetContainer.fatherLastEducation = reader[DatabaseUtility.fatherCrudLastEducation].ToString();
                        targetContainer.fatherJob = reader[DatabaseUtility.fatherCrudJob].ToString();

                        targetContainer.motherName = reader[DatabaseUtility.motherCrudName].ToString();
                        targetContainer.motherYearOfBirth = reader[DatabaseUtility.motherCrudYearOfBirth].ToString();
                        targetContainer.motherId = reader[DatabaseUtility.motherCrudId].ToString();
                        targetContainer.motherLastEducation = reader[DatabaseUtility.motherCrudLastEducation].ToString();
                        targetContainer.motherJob = reader[DatabaseUtility.motherCrudJob].ToString();

                        targetContainer.tall = reader[DatabaseUtility.studentCrudTall].ToString();
                        targetContainer.weight = reader[DatabaseUtility.studentCrudWeight].ToString();
                        targetContainer.range = reader[DatabaseUtility.studentCrudRange].ToString();
                        targetContainer.brotherSisterCount = reader[DatabaseUtility.studentCrudBrotherSisterCount].ToString();
                        targetContainer.classGroup = reader[DatabaseUtility.studentCrudClass].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error : Data tidak ditemukan.");
                    }

                    connection.Close(); 
                }
                catch (Exception ex)
                {
                    //:: menampilkan berupa pesan error
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }
        public void addNewStudent(DataGridView gridView)
        {
            StudentsCRUD studentsCRUDInterfaces = new StudentsCRUD(message =>
            {
                    this.bindData(gridView);
                    this.showMessageBox("Sukses", message);
            });
            studentsCRUDInterfaces.Show();
        }

        public void editStudent(DataGridView gridView, StudentsDTO targetStudent)
        {
            bindDataForId(targetStudent.id, targetStudent);
            StudentsCRUD studentsCRUDInterfaces = new StudentsCRUD(message =>
            {
                this.bindData(gridView);
                this.showMessageBox("Sukses", message);
            });
            studentsCRUDInterfaces.setEditData(targetStudent);
            studentsCRUDInterfaces.Show();
        }

        public void deleteStudent(DataGridView gridView, StudentsDTO targetStudent)
        {
            var customConfirmation = new CustomConfirmation("Perhatian", "Yakin hapus data siswa ini?", () =>
            {
                using (OleDbConnection connection = DatabaseUtility.GetConnection())
                {
                    try
                    {
                        OleDbCommand command = new OleDbCommand(DatabaseUtility.getDeleteStudentQuery(targetStudent.id), connection);

                        //:: state oledbconnection harus di buka dulu dengan methode Open()
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        this.bindData(gridView);
                        this.showMessageBox("Sukses", "Siswa berhasil dihapus!");
                    }
                    catch (Exception ex)
                    {
                        //:: menampilkan berupa pesan error
                        MessageBox.Show("Error : " + ex.Message);
                    }
                }
            });
            customConfirmation.Show(); 
        }

        // Custom Message Box -----------------------------------------------------------
        public void showMessageBox(string title, string msg)
        {
            var customMessageBox = new CustomMessageBox(title, msg);
            customMessageBox.Show();
        }
    }
}

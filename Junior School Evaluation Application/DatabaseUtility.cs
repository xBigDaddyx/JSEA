using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public static class DatabaseUtility
    {
        //:::: variable static dan readonly untuk nama database 
        private static readonly string DatabaseFileName = "master_db.accdb";
        private const string DatabasePassword = "W@mb1s"; 
        public static string AuthUsername = "ID"; //:: kolom username
        public static string AuthPassword = "Teacher_password"; //:: kolom password
        public static string AuthTable = "Teachers"; //:: nama table untuk autentikasi


        //:::: variable static lokasi/path database berada
        public static string DatabasePath = System.IO.Path.Combine(Application.StartupPath, DatabaseFileName);

        public static string GetLoginQuery()
        {
            return "SELECT " + AuthPassword + " FROM " + AuthTable + " where " + AuthUsername + " = @Username";
        }



        // semua database yang dibutuhkan oleh STUDENTS ------------------------------------------------

        public static string studentTable = "Teachers";

        public static string studentCrudName = "name";
        public static string studentCrudGender = "gender";
        public static string studentCrudId = "id";
        public static string studentCrudBirthPlace = "birth_place";
        public static string studentCrudBirthDate = "birth_date";
        public static string studentCrudReligion = "religion";
        public static string studentCrudNation = "nation";
        public static string studentCrudAddress = "address";
        public static string studentCrudHouseWith = "living_with";
        public static string studentCrudBirthOrder = "birth_order";
        public static string studentCrudAge = "age";
        public static string studentCrudPhoneNumber = "phone_number";

        public static string fatherCrudName = "father_name";
        public static string fatherCrudId = "father_id";
        public static string fatherCrudYearOfBirth = "father_year_of_birth";
        public static string fatherCrudLastEducation = "father_education";
        public static string fatherCrudJob = "father_job";

        public static string motherCrudName = "mother_name";
        public static string motherCrudId = "mother_id";
        public static string motherCrudYearOfBirth = "mother_year_of_birth";
        public static string motherCrudLastEducation = "mother_education";
        public static string motherCrudJob = "mother_job";

        public static string studentCrudTall = "tall";
        public static string studentCrudWeight = "weight";
        public static string studentCrudRange = "range_from_home";
        public static string studentCrudBrotherSisterCount = "brother_sister_count";

        public static string studentCrudClass = "class_id";

        public static string getViewStudentQuery()
        {
            string _command = "SELECT * FROM " + studentTable;
            return _command;
        }

        public static string getCreateStudentQuery(Students.Models.StudentsDTO newStudent)
        {
            string _command = "INSERT INTO " + studentTable + " (";

            _command += "ID, Teacher_name, Teacher_password, Teacher_address, Teacher_phone";

           /* _command += studentCrudName;
            _command += studentCrudGender;
            _command += studentCrudId;
            _command += studentCrudBirthPlace;
            _command += studentCrudBirthDate;
            _command += studentCrudReligion;
            _command += studentCrudNation;
            _command += studentCrudAddress;
            _command += studentCrudHouseWith;
            _command += studentCrudBirthOrder;
            _command += studentCrudAge;
            _command += studentCrudPhoneNumber;

            _command += fatherCrudName;
            _command += fatherCrudId;
            _command += fatherCrudYearOfBirth;
            _command += fatherCrudLastEducation;
            _command += fatherCrudJob;

            _command += motherCrudName;
            _command += motherCrudId;
            _command += motherCrudYearOfBirth;
            _command += motherCrudLastEducation;
            _command += motherCrudJob;

            _command += studentCrudClass;

            _command += studentCrudTall;
            _command += studentCrudWeight;
            _command += studentCrudRange;
            _command += studentCrudBrotherSisterCount;*/

            _command += ") VALUES (";

            /*_command += "'" + newStudent.id + "', ";
            _command += "'" + newStudent.name + "', ";
            _command += "'" + newStudent.bornPlace + "', ";
            _command += "'" + newStudent.address + "', ";
            _command += "'" + newStudent.phoneNumber + "'";*/

            _command += "@1, ";
            _command += "@2, ";
            _command += "@3, ";
            _command += "@4, ";
            _command += "@5";

            /*_command += newStudent.name + ", ";
            _command += newStudent.gender + ", ";
            _command += newStudent.id + ", ";
            _command += newStudent.bornPlace + ", ";
            _command += newStudent.bornDate + ", ";
            _command += newStudent.religion + ", ";
            _command += newStudent.nation + ", ";
            _command += newStudent.address + ", ";
            _command += newStudent.livingWith + ", ";
            _command += newStudent.bornOrder + ", ";
            _command += newStudent.age + ", ";
            _command += newStudent.phoneNumber + ", ";

            _command += newStudent.fatherName + ", ";
            _command += newStudent.fatherId + ", ";
            _command += newStudent.fatherYearOfBirth + ", ";
            _command += newStudent.fatherLastEducation + ", ";
            _command += newStudent.fatherJob + ", ";

            _command += newStudent.motherName + ", ";
            _command += newStudent.motherId + ", ";
            _command += newStudent.motherYearOfBirth + ", ";
            _command += newStudent.motherLastEducation + ", ";
            _command += newStudent.motherJob + ", ";

            _command += newStudent.tall + ", ";
            _command += newStudent.weight + ", ";
            _command += newStudent.range + ", ";
            _command += newStudent.brotherSisterCount + ", ";

            _command += newStudent.classGroup + ", ";*/

            _command += ");";

            return _command;
        }
        
        public static string getUpdateStudentQuery(string tblColName, string id, string newValue)
        {
            string _command = "UPDATE " + studentTable;
            _command += " SET " + tblColName + " = " + newValue;
            _command += " WHERE " + studentCrudId + " = " + id;
            return _command;
        }

        public static string getDeleteStudentQuery(string tblColName, string id)
        {
            string _command = "DELETE FROM " + studentTable;
            _command += " WHERE " + studentCrudId + " = " + id;
            return _command;
        }

        // ---------------------------------------------------------------------------------------------



        //:::: fungsi public untuk koneksi dengan database
        public static OleDbConnection GetConnection()
        {
            //:: ya karena pake access, menggunakan provider oledb
            return new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};Jet OLEDB:Database Password={DatabasePassword}");
        }

        public static string HashPassword(string password)
        {
            //:: membuat variable enkripsi SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                //:: membuat data type byte array dari hasil enkripsi password dengan sha256
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                //:: membuat instansi variable baru untuk string builder
                StringBuilder builder = new StringBuilder();
                //:: setiap value dari variable byte akan di append/di gabung dalam sebuah string ke dalam variable builder
                foreach(byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

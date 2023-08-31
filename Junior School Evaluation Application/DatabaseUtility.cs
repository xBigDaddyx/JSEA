using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public static class DatabaseUtility
    {
        //:::: variable static dan readonly untuk nama database 
        private static readonly string DatabaseFileName = "master_db.accdb";
        private const string DatabasePassword = "W@mb1s"; 
        public static string AuthUsername = "id"; //:: kolom username
        public static string AuthPassword = "password"; //:: kolom password
        public static string AuthTable = "teachers"; //:: nama table untuk autentikasi


        //:::: variable static lokasi/path database berada
        public static string DatabasePath = System.IO.Path.Combine(Application.StartupPath, DatabaseFileName);
        //public static string DatabasePath = "E:/DevEnv/Projects/Desktop/JSEA/Junior School Evaluation Application/"+ DatabaseFileName;

        public static string getRegisteredQuery()
        {
            return "SELECT COUNT(*) FROM " + AuthTable;
        }
        public static string getRegisterQuery()
        {
            return "INSERT INTO " + AuthTable + " VALUES(@id,@nama,@password,@telepon,@alamat)";
        }
        public static string getConnectionString()
        {
            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+DatabasePath+ ";Jet OLEDB:Database Password=W@mb1s;";
        }
        public static string GetLoginQuery()
        {
            return "SELECT " + AuthPassword + " FROM " + AuthTable + " where " + AuthUsername + " = @Username";
        }





        // semua database yang dibutuhkan oleh CLASSES ------------------------------------------------

        public static string classesTable = "classes";

        public static string classesCrudId = "id";
        public static string classesCrudName = "name";
        public static string classesCrudCapacity = "capacity";

        public static string getViewClassesQuery()
        {
            string _command = "SELECT ";

            _command += classesCrudId + ", ";
            _command += classesCrudName + ", ";
            _command += classesCrudCapacity;

            _command += " FROM " + classesTable;

            return _command;
        }

        public static string getViewClassesSpesificQuery(string id)
        {
            string _command = "SELECT * FROM " + classesTable + " WHERE " + classesCrudId + " = '" + id + "'";
            return _command;
        }

        public static string getCreateClassesQuery(Classes.Models.ClassesDTO newClasses)
        {
            string _command = "INSERT INTO " + classesTable + " (";

            _command += classesCrudId + ", ";
            _command += classesCrudName + ", ";
            _command += classesCrudCapacity;

            _command += ") VALUES (";

            _command += "'" + newClasses.id + "', ";
            _command += "'" + newClasses.name + "', ";
            _command += "'" + newClasses.capacity + "'";

            _command += ")";

            return _command;
        }

        public static string getUpdateClassesQuery(Classes.Models.ClassesDTO targetClasses)
        {
            string _command = "UPDATE " + classesTable + " SET ";

            /*_command += classesCrudId + " = '" + targetClasses.id + "', ";*/
            _command += classesCrudName + " = '" + targetClasses.name + "', ";
            _command += classesCrudCapacity + " = '" + targetClasses.capacity + "'";

            _command += " WHERE " + classesCrudId + " = '" + targetClasses.id + "'";

            return _command;
        }

        public static string getDeleteClassesQuery(string id)
        {
            string _command = "DELETE FROM " + classesTable;
            _command += " WHERE " + classesCrudId + " = '" + id + "'";
            return _command;
        }

        // ---------------------------------------------------------------------------------------------







        // semua database yang dibutuhkan oleh STUDENTS ------------------------------------------------

        public static string studentTable = "students";

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
            string _command = "SELECT ";

            _command += studentCrudId + ", ";
            _command += studentCrudName + ", ";
            _command += studentCrudPhoneNumber + ", ";
            _command += studentCrudClass;

            _command += " FROM " + studentTable;

            return _command;
        }
        
        public static string getViewStudentSpesificQuery(string id)
        {
            string _command = "SELECT * FROM " + studentTable + " WHERE " + studentCrudId + " = '" + id + "'";
            return _command;
        }

        public static string getCreateStudentQuery(Students.Models.StudentsDTO newStudent)
        {
            string _command = "INSERT INTO " + studentTable + " (";

            _command += studentCrudName + ", ";
            _command += studentCrudGender + ", ";
            _command += studentCrudId + ", ";
            _command += studentCrudBirthPlace + ", ";
            _command += studentCrudBirthDate + ", ";
            _command += studentCrudReligion + ", ";
            _command += studentCrudNation + ", ";
            _command += studentCrudAddress + ", ";
            _command += studentCrudHouseWith + ", ";
            _command += studentCrudBirthOrder + ", ";
            _command += studentCrudAge + ", ";
            _command += studentCrudPhoneNumber + ", ";

            _command += fatherCrudName + ", ";
            _command += fatherCrudId + ", ";
            _command += fatherCrudYearOfBirth + ", ";
            _command += fatherCrudLastEducation + ", ";
            _command += fatherCrudJob + ", ";

            _command += motherCrudName + ", ";
            _command += motherCrudId + ", ";
            _command += motherCrudYearOfBirth + ", ";
            _command += motherCrudLastEducation + ", ";
            _command += motherCrudJob + ", ";
            _command += studentCrudTall + ", ";
            _command += studentCrudWeight + ", ";
            _command += studentCrudRange + ", ";
            _command += studentCrudBrotherSisterCount + ", ";
            _command += studentCrudClass;

            _command += ") VALUES (";

            _command += "'" + newStudent.name + "', ";
            _command += "'" + newStudent.gender + "', ";
            _command += "'" + newStudent.id + "', ";
            _command += "'" + newStudent.bornPlace + "', ";
            _command += "'" + newStudent.bornDate + "', ";
            _command += "'" + newStudent.religion + "', ";
            _command += "'" + newStudent.nation + "', ";
            _command += "'" + newStudent.address + "', ";
            _command += "'" + newStudent.livingWith + "', ";
            _command += newStudent.bornOrder + ", ";
            _command += newStudent.age + ", ";
            _command += "'" + newStudent.phoneNumber + "', ";

            _command += "'" + newStudent.fatherName + "', ";
            _command += "'" + newStudent.fatherId + "', ";
            _command += "'" + newStudent.fatherYearOfBirth + "', ";
            _command += "'" + newStudent.fatherLastEducation + "', ";
            _command += "'" + newStudent.fatherJob + "', ";

            _command += "'" + newStudent.motherName + "', ";
            _command += "'" + newStudent.motherId + "', ";
            _command += "'" + newStudent.motherYearOfBirth + "', ";
            _command += "'" + newStudent.motherLastEducation + "', ";
            _command += "'" + newStudent.motherJob + "', ";

            _command += newStudent.tall + ", ";
            _command += newStudent.weight + ", ";
            _command += "'" + newStudent.range + "', ";
            _command += newStudent.brotherSisterCount + ", ";

            _command += "'" + newStudent.classGroup + "'";

            _command += ")";

            return _command;
        }
        
        public static string getUpdateStudentQuery(Students.Models.StudentsDTO targetStudent)
        {
            string _command = "UPDATE " + studentTable + " SET ";

            _command += studentCrudName + " = '" + targetStudent.name + "', ";
            _command += studentCrudGender + " = '" + targetStudent.gender + "', ";
            /*_command += studentCrudId + " = '" + targetStudent.id + "', ";*/
            _command += studentCrudBirthPlace + " = '" + targetStudent.bornPlace + "', ";
            _command += studentCrudBirthDate + " = '" + targetStudent.bornDate + "', ";
            _command += studentCrudReligion + " = '" + targetStudent.religion + "', ";
            _command += studentCrudNation + " = '" + targetStudent.nation + "', ";
            _command += studentCrudAddress + " = '" + targetStudent.address + "', ";
            _command += studentCrudHouseWith + " = '" + targetStudent.livingWith + "', ";
            _command += studentCrudBirthOrder + " = " + targetStudent.bornOrder + ", ";
            _command += studentCrudAge + " = " + targetStudent.age + ", ";
            _command += studentCrudPhoneNumber + " = '" + targetStudent.phoneNumber + "', ";

            _command += fatherCrudName + " = '" + targetStudent.fatherName + "', ";
            _command += fatherCrudId + " = '" + targetStudent.fatherId + "', ";
            _command += fatherCrudYearOfBirth + " = '" + targetStudent.fatherYearOfBirth + "', ";
            _command += fatherCrudLastEducation + " = '" + targetStudent.fatherLastEducation + "', ";
            _command += fatherCrudJob + " = '" + targetStudent.fatherJob + "', ";

            _command += motherCrudName + " = '" + targetStudent.motherName + "', ";
            _command += motherCrudId + " = '" + targetStudent.motherId + "', ";
            _command += motherCrudYearOfBirth + " = '" + targetStudent.motherYearOfBirth + "', ";
            _command += motherCrudLastEducation + " = '" + targetStudent.motherLastEducation + "', ";
            _command += motherCrudJob + " = '" + targetStudent.motherJob + "', ";

            _command += studentCrudTall + " = " + targetStudent.tall + ", ";
            _command += studentCrudWeight + " = " + targetStudent.weight + ", ";
            _command += studentCrudRange + " = '" + targetStudent.range + "', ";
            _command += studentCrudBrotherSisterCount + " = " + targetStudent.brotherSisterCount + ", ";

            _command += studentCrudClass + " = '" + targetStudent.classGroup + "'";
              
            _command += " WHERE " + studentCrudId + " = '" + targetStudent.id + "'";

            return _command;
        }

        public static string getDeleteStudentQuery(string id)
        {
            string _command = "DELETE FROM " + studentTable;
            _command += " WHERE " + studentCrudId + " = '" + id + "'";
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
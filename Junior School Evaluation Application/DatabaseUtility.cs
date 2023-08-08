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
        public static string AuthUsername = "Username"; //:: kolom username
        public static string AuthPassword = "Password"; //:: kolom password
        public static string AuthTable = "Teachers"; //:: nama table untuk autentikasi
        //:::: variable static lokasi/path database berada
        public static string DatabasePath => System.IO.Path.Combine(Application.StartupPath, DatabaseFileName);

        //:::: fungsi public untuk koneksi dengan database
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath};");
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach(byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();

                    //:: menentukan query untuk mengambil password dengan parameter username
                    string query = "INSERT INTO Customers(" + DatabaseUtility.CRUDId + "," + DatabaseUtility.CRUDNik + "," + DatabaseUtility.CRUDNama + "," + DatabaseUtility.CRUDPassword + ") VALUES('a', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger');";

                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(query, connection);
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

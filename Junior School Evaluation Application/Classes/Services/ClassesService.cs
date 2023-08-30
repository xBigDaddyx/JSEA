using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Junior_School_Evaluation_Application.Classes.Models;
using System.Data.SqlClient;

namespace Junior_School_Evaluation_Application.Classes.Services
{
    public class ClassesService
    { 
        public ClassesService()
        { 

        }
         
        public void bindData(DataGridView gridView)
        {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getViewClassesQuery(), connection);

                    DataTable dTable = new DataTable();

                    //:: menambahkan kolom nomor dengan nama "rowNumb" ke data tabel 
                    dTable.Columns.Add("rowNumb", typeof(int));
                    dTable.Columns["rowNumb"].AutoIncrement = true;
                    dTable.Columns["rowNumb"].AutoIncrementSeed = 1;

                    OleDbDataAdapter sqlAdpt = new OleDbDataAdapter(command);

                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();
                    sqlAdpt.Fill(dTable);
                    connection.Close();

                    //:: mengisikan data ke dataGrid parameter dengan data tabel dari database
                    gridView.DataSource = dTable;

                    //:: mengubah beberapa atribut kolom datagridview secara masive
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        gridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        gridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }

                    //:: mengubah beberapa atribut kolom datagridview secara individual
                    gridView.Columns["rowNumb"].HeaderText = "No";
                    gridView.Columns[DatabaseUtility.classesCrudId].Visible = false;
                    gridView.Columns[DatabaseUtility.classesCrudName].HeaderText = "Nama Kelas";
                    gridView.Columns[DatabaseUtility.classesCrudName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    gridView.Columns[DatabaseUtility.classesCrudCapacity].HeaderText = "Kapasitas";
                }
                catch (Exception ex)
                {
                    //:: menampilkan berupa pesan error
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        public void bindDataForId(string id, ClassesDTO targetContainer)
        {
            using (OleDbConnection connection = DatabaseUtility.GetConnection())
            {
                try
                {
                    //:: variable oledbcommand dengan mengeksekusi perintah dari query dengan koneksi dari variable connection
                    OleDbCommand command = new OleDbCommand(DatabaseUtility.getViewClassesSpesificQuery(id), connection);
                      
                    //:: state oledbconnection harus di buka dulu dengan methode Open()
                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        targetContainer.id = reader[DatabaseUtility.classesCrudId].ToString();
                        targetContainer.name = reader[DatabaseUtility.classesCrudName].ToString(); 
                        targetContainer.capacity = reader[DatabaseUtility.classesCrudCapacity].ToString();
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

        public void addNewClasses(DataGridView gridView)
        {
            ClassesCRUD classesCRUDInterface = new ClassesCRUD(message =>
            {
                    this.bindData(gridView);
                    this.showMessageBox("Sukses", message);
            });
            classesCRUDInterface.Show();
        }

        public void editClasses(DataGridView gridView, ClassesDTO targetClasses)
        {
            bindDataForId(targetClasses.id, targetClasses);
            ClassesCRUD classesCRUDInterface = new ClassesCRUD(message =>
            {
                this.bindData(gridView);
                this.showMessageBox("Sukses", message);
            });
            classesCRUDInterface.setEditData(targetClasses);
            classesCRUDInterface.Show();
        }

        public void deleteClasses(DataGridView gridView, ClassesDTO targetClasses)
        {
            var customConfirmation = new CustomConfirmation("Perhatian", "Yakin hapus data siswa ini?", () =>
            {
                using (OleDbConnection connection = DatabaseUtility.GetConnection())
                {
                    try
                    {
                        OleDbCommand command = new OleDbCommand(DatabaseUtility.getDeleteClassesQuery(targetClasses.id), connection);

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

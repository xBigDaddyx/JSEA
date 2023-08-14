﻿using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using Junior_School_Evaluation_Application.Students.Models;

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
                    dTable.Columns[2].ColumnName = "Kelas";

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
            StudentsCRUD studentsCRUDInterfaces = new StudentsCRUD(message =>
            {
                    this.bindData(gridView);
                    this.showMessageBox("Sukses", message);
            });
            studentsCRUDInterfaces.setEditData(targetStudent);
            studentsCRUDInterfaces.Show(); 
        }

         // Custom Message Box -----------------------------------------------------------
        public void showMessageBox(string title, string msg)
        {
            var customMessageBox = new CustomMessageBox(title, msg);
            customMessageBox.Show(); 
        }
    }
}

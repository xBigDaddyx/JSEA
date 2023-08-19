namespace Junior_School_Evaluation_Application.Students.Services
{
    partial class StudentsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.dgrid_list_student = new System.Windows.Forms.DataGridView();
            this.btn_exit = new System.Windows.Forms.Button();
            this.dataSet1 = new Junior_School_Evaluation_Application.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_list_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_new.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_new.Location = new System.Drawing.Point(17, 58);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(150, 60);
            this.btn_new.TabIndex = 22;
            this.btn_new.Text = "Tambah +";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.dgrid_list_student);
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 24F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1321, 856);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Siswa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.77965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.22035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Controls.Add(this.btn_delete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_update, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_selected, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(172, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 81);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(982, 10);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(148, 60);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Hapus";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_update.BackColor = System.Drawing.Color.Orange;
            this.btn_update.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(825, 10);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 60);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Ubah";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_selected
            // 
            this.lbl_selected.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_selected.AutoSize = true;
            this.lbl_selected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_selected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_selected.Location = new System.Drawing.Point(793, 22);
            this.lbl_selected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(26, 36);
            this.lbl_selected.TabIndex = 27;
            this.lbl_selected.Text = "-";
            this.lbl_selected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgrid_list_student
            // 
            this.dgrid_list_student.AllowUserToAddRows = false;
            this.dgrid_list_student.AllowUserToDeleteRows = false;
            this.dgrid_list_student.AllowUserToResizeColumns = false;
            this.dgrid_list_student.AllowUserToResizeRows = false;
            this.dgrid_list_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_list_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 24F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_list_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_list_student.ColumnHeadersHeight = 50;
            this.dgrid_list_student.Location = new System.Drawing.Point(17, 129);
            this.dgrid_list_student.MultiSelect = false;
            this.dgrid_list_student.Name = "dgrid_list_student";
            this.dgrid_list_student.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 24F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "- belum ada data -";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_list_student.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_list_student.RowHeadersVisible = false;
            this.dgrid_list_student.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            this.dgrid_list_student.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_list_student.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgrid_list_student.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgrid_list_student.RowTemplate.Height = 40;
            this.dgrid_list_student.RowTemplate.ReadOnly = true;
            this.dgrid_list_student.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_list_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_list_student.Size = new System.Drawing.Size(1289, 705);
            this.dgrid_list_student.TabIndex = 25;
            this.dgrid_list_student.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_list_student_CellEnter);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Salmon;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Location = new System.Drawing.Point(1183, 874);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(150, 60);
            this.btn_exit.TabIndex = 24;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1345, 946);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentsListInterfaces_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_list_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DataGridView dgrid_list_student;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_selected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
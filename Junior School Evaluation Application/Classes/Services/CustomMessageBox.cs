using System;
using System.Drawing;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Classes.Services
{ 
    public class CustomMessageBox : Form
    {
        private Timer fadeTimer;
        private int fadeStep = 10;
        private Button btn_ok;
        private Label lbl_title;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_msg;
        private int showStep = 0;

        public CustomMessageBox(string title, string message)
        {
            InitializeComponent();

            lbl_title.Text = title;
            lbl_msg.Text = message;
             
            // Inisialisasi timer
            fadeTimer = new Timer();
            fadeTimer.Interval = 5; // 5 milliseconds
            fadeTimer.Tick += FadeTimer_Tick;

            // Animasi fade-in
            Opacity = 0;
            fadeStep = 50;
            fadeTimer.Start();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (fadeStep <= 0)
            {
                // Animasi selesai, hentikan timer
                fadeTimer.Stop();

                // Animasi fade-ou
                if (showStep == 1)
                {
                    this.Dispose();
                }

                showStep++;
                return;
            }

            // Animasi fade-in
            if (showStep == 0)
            {
                Opacity += 0.05;
            }

            // Animasi fade-ou
            if (showStep == 1)
            {
                Opacity -= 0.1;
            }

            fadeStep--;
        } 

        private void InitializeComponent()
        {
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ok.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ok.Location = new System.Drawing.Point(115, 161);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(150, 60);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.TabStop = false;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click_1);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(151, 8);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(78, 29);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Judul";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_msg, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ok, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.93464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.38562F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.67974F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 230);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_msg
            // 
            this.lbl_msg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_msg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.Location = new System.Drawing.Point(131, 90);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(118, 18);
            this.lbl_msg.TabIndex = 2;
            this.lbl_msg.Text = "..isi dari pesan..";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomMessageBox
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(394, 244);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            // Animasi fade-out saat tombol OK ditekan
            fadeStep = 10;
            fadeTimer.Start();
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

namespace Junior_School_Evaluation_Application.Auth.Views
{
    partial class Login
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.illustrationPanel = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.illustrationPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.lbl_title);
            this.titlePanel.Controls.Add(this.btn_close);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(680, 36);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greeting.ForeColor = System.Drawing.Color.White;
            this.lbl_greeting.Location = new System.Drawing.Point(62, 60);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(84, 33);
            this.lbl_greeting.TabIndex = 15;
            this.lbl_greeting.Text = "Hello!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Please login with your credential.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Then start your journey!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(126, 172);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(129, 20);
            this.txt_username.TabIndex = 14;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(126, 196);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(129, 20);
            this.txt_password.TabIndex = 16;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(62, 246);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(193, 38);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.formPanel.Controls.Add(this.btn_login);
            this.formPanel.Controls.Add(this.txt_password);
            this.formPanel.Controls.Add(this.txt_username);
            this.formPanel.Controls.Add(this.label5);
            this.formPanel.Controls.Add(this.label4);
            this.formPanel.Controls.Add(this.label3);
            this.formPanel.Controls.Add(this.label2);
            this.formPanel.Controls.Add(this.lbl_greeting);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.formPanel.Location = new System.Drawing.Point(363, 36);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(317, 325);
            this.formPanel.TabIndex = 6;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(637, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(43, 36);
            this.btn_close.TabIndex = 25;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // illustrationPanel
            // 
            this.illustrationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.illustrationPanel.Image = global::Junior_School_Evaluation_Application.Properties.Resources.login_illu;
            this.illustrationPanel.Location = new System.Drawing.Point(0, 36);
            this.illustrationPanel.Name = "illustrationPanel";
            this.illustrationPanel.Size = new System.Drawing.Size(363, 325);
            this.illustrationPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.illustrationPanel.TabIndex = 8;
            this.illustrationPanel.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(33, 13);
            this.lbl_title.TabIndex = 26;
            this.lbl_title.Text = "Login";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 361);
            this.Controls.Add(this.illustrationPanel);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "login-form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Paint);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.illustrationPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.PictureBox illustrationPanel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_title;
    }
}
namespace Junior_School_Evaluation_Application
{
    partial class MainDashboard
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
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.navButton3 = new System.Windows.Forms.Button();
            this.navButton2 = new System.Windows.Forms.Button();
            this.navButton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(65)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 36);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nightControlBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(884, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 36);
            this.panel2.TabIndex = 5;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(217)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.White;
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.White;
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.White;
            this.nightControlBox1.Location = new System.Drawing.Point(0, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 6;
            // 
            // navigationPanel
            // 
            this.navigationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(56)))), ((int)(((byte)(158)))));
            this.navigationPanel.Controls.Add(this.button1);
            this.navigationPanel.Controls.Add(this.navButton3);
            this.navigationPanel.Controls.Add(this.navButton2);
            this.navigationPanel.Controls.Add(this.navButton1);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 36);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Padding = new System.Windows.Forms.Padding(10);
            this.navigationPanel.Size = new System.Drawing.Size(200, 452);
            this.navigationPanel.TabIndex = 5;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(200, 36);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(824, 452);
            this.bodyPanel.TabIndex = 6;
            // 
            // navButton3
            // 
            this.navButton3.BackColor = System.Drawing.Color.Transparent;
            this.navButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.navButton3.FlatAppearance.BorderSize = 0;
            this.navButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(217)))));
            this.navButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navButton3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navButton3.ForeColor = System.Drawing.Color.White;
            this.navButton3.Image = global::Junior_School_Evaluation_Application.Properties.Resources.classes_icon_16;
            this.navButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton3.Location = new System.Drawing.Point(10, 90);
            this.navButton3.Margin = new System.Windows.Forms.Padding(10);
            this.navButton3.Name = "navButton3";
            this.navButton3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.navButton3.Size = new System.Drawing.Size(180, 40);
            this.navButton3.TabIndex = 8;
            this.navButton3.Text = "     Classes";
            this.navButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton3.UseVisualStyleBackColor = false;
            this.navButton3.Click += new System.EventHandler(this.navButton3_Click);
            // 
            // navButton2
            // 
            this.navButton2.BackColor = System.Drawing.Color.Transparent;
            this.navButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.navButton2.FlatAppearance.BorderSize = 0;
            this.navButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(217)))));
            this.navButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navButton2.ForeColor = System.Drawing.Color.White;
            this.navButton2.Image = global::Junior_School_Evaluation_Application.Properties.Resources.users_white__1___1_;
            this.navButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton2.Location = new System.Drawing.Point(10, 50);
            this.navButton2.Margin = new System.Windows.Forms.Padding(10);
            this.navButton2.Name = "navButton2";
            this.navButton2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.navButton2.Size = new System.Drawing.Size(180, 40);
            this.navButton2.TabIndex = 7;
            this.navButton2.Text = "     Students";
            this.navButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton2.UseVisualStyleBackColor = false;
            this.navButton2.Click += new System.EventHandler(this.navButton2_Click);
            // 
            // navButton1
            // 
            this.navButton1.BackColor = System.Drawing.Color.Transparent;
            this.navButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navButton1.FlatAppearance.BorderSize = 0;
            this.navButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(217)))));
            this.navButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navButton1.ForeColor = System.Drawing.Color.White;
            this.navButton1.Image = global::Junior_School_Evaluation_Application.Properties.Resources.apps_white__1___1_;
            this.navButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton1.Location = new System.Drawing.Point(10, 10);
            this.navButton1.Margin = new System.Windows.Forms.Padding(10);
            this.navButton1.Name = "navButton1";
            this.navButton1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.navButton1.Size = new System.Drawing.Size(180, 40);
            this.navButton1.TabIndex = 6;
            this.navButton1.Text = "     Dashboard";
            this.navButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navButton1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(86)))), ((int)(((byte)(217)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Junior_School_Evaluation_Application.Properties.Resources.studies_icon_16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "     Studies";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 488);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.MaximizedBoundsChanged += new System.EventHandler(this.MainDashboard_MaximizedBoundsChanged);
            this.MaximumSizeChanged += new System.EventHandler(this.MainDashboard_MaximumSizeChanged);
            this.SizeChanged += new System.EventHandler(this.MainDashboard_SizeChanged);
            this.Resize += new System.EventHandler(this.MainDashboard_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button navButton3;
        private System.Windows.Forms.Button navButton2;
        private System.Windows.Forms.Button navButton1;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Button button1;
    }
}
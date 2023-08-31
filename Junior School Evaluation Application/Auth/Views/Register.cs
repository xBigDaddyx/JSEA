using ExCSS;
using Junior_School_Evaluation_Application.Auth.Models;
using Junior_School_Evaluation_Application.Auth.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Auth.Views
{
    public partial class Register : Form
    {
        private TeacherRegisterService services;
        public Register(TeacherRegisterService services)
        {
            
            InitializeComponent();
            this.services = services;
            
        }
        
        private void Register_Load(object sender, EventArgs e)
        {
            
           
            this.titlePanel.BackColor = Theme.primary;
            this.BackColor = Theme.headerGridHover;
            this.formPanel.BackColor = Theme.MainBg;
            this.inputPanel.BackColor = System.Drawing.Color.White;

            //control
            this.btn_register.BackColor = Theme.primary;
            this.btn_register.FlatAppearance.MouseOverBackColor = Theme.NavButtonHover;
            this.btn_register.FlatAppearance.MouseDownBackColor = Theme.warning;

            this.btn_close.BackColor = Theme.danger;
            this.btn_close.FlatAppearance.MouseOverBackColor = Theme.NavButtonHover;
            this.btn_close.FlatAppearance.MouseDownBackColor = Theme.primary;
            //this.idPanel.BackColor = Theme.primary;
            //this.namaPanel.BackColor = Theme.primary;
            // this.teleponPanel.BackColor = Theme.primary;
            // this.alamatPanel.BackColor = Theme.primary;

        }

        private void txt_id_Enter(object sender, EventArgs e)
        {
            //this.idPanel.BackColor = Theme.warning;
        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            //this.idPanel.BackColor = Theme.primary;
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
           // this.namaPanel.BackColor = Theme.warning;
        }

        private void txt_telepon_Enter(object sender, EventArgs e)
        {
            //this.teleponPanel.BackColor = Theme.warning;
        }

        private void txt_alamat_Enter(object sender, EventArgs e)
        {
            //this.alamatPanel.BackColor = Theme.warning;
        }

        private void txt_alamat_Leave(object sender, EventArgs e)
        {
           // this.alamatPanel.BackColor = Theme.primary;
        }

        private void txt_telepon_Leave(object sender, EventArgs e)
        {
            //this.teleponPanel.BackColor = Theme.primary;
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
           // this.namaPanel.BackColor = Theme.primary;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
           
            services.Register(this.txt_id.Text, this.txt_name.Text, this.txt_password.Text, this.txt_telepon.Text, this.txt_alamat.Text);
        }
    }
}

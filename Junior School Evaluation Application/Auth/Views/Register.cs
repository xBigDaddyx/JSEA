using ExCSS;
using Junior_School_Evaluation_Application.Auth.Models;
using Junior_School_Evaluation_Application.Auth.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application.Auth.Views
{
    public partial class Register : Form
    {
        private int borderRadius = 20;
        private int borderSize = 1;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private TeacherRegisterService services;
        public Register(TeacherRegisterService services)
        {
            this.Padding = new Padding(borderSize);
            InitializeComponent();
            this.services = services;
            
        }
        private void DrawPath(Rectangle rect, Graphics graph, System.Drawing.Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        private struct FormBoundsColors
        {
            public System.Drawing.Color TopLeftColor;
            public System.Drawing.Color TopRightColor;
            public System.Drawing.Color BottomLeftColor;
            public System.Drawing.Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, System.Drawing.Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, System.Drawing.Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, System.Drawing.Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, System.Drawing.Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, System.Drawing.Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void Register_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_id;
            ThemeUtility.ApplyButtonTheme(btn_close);
            ThemeUtility.ApplyButtonTheme(btn_register);
            ThemeUtility.ApplyTheme(this);
           

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
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
           
            services.Register(this.txt_id.Text, this.txt_name.Text, this.txt_password.Text, this.txt_telepon.Text, this.txt_alamat.Text);
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Register_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, Colors.primary, borderSize);
        }

        private void txt_telepon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                services.Register(this.txt_id.Text, this.txt_name.Text, this.txt_password.Text, this.txt_telepon.Text, this.txt_alamat.Text);
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                services.Register(this.txt_id.Text, this.txt_name.Text, this.txt_password.Text, this.txt_telepon.Text, this.txt_alamat.Text);
            }
        }
    }
}

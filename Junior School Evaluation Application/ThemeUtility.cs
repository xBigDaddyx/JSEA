using Junior_School_Evaluation_Application.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    public static class ThemeUtility
    {
      
        public static void ApplyTheme(Form form)
        {
            foreach (System.Windows.Forms.Control control in form.Controls)
            {
                if(control is Panel panel)
                {
                    foreach(System.Windows.Forms.Control control2 in panel.Controls)
                    {
                        if (control2 is Label label)
                        {
                            if(label.Name == "lbl_greeting")
                            {
                                ApplyLabelTheme(label, "Bold",20);
                            }
                            ApplyLabelTheme(label,"Regular");
                            label.ForeColor = Colors.mainFore;
                        }else if (control2 is Panel panel2)
                        {
                            if(panel2.Name == "inputPanel")
                            {
                                panel2.BackColor =Colors.mainBg;
                            }
                        }
                    }

                   

                    if (panel.Name == "titlePanel")
                    {
                        foreach(System.Windows.Forms.Control control3 in panel.Controls)
                        {
                            if(control3 is Label label)
                            {
                                ApplyLabelTheme(label,"Bold",14);
                                label.ForeColor = Colors.mainForeAlt;
                            }
                           
                        }
                        panel.BackColor = Colors.primary;
                        
                    }else if (panel.Name == "formPanel")
                    {
                        panel.BackColor = Colors.mainBg;
                    }else if(panel.Name == "illustrationPanel")
                    {
                        panel.BackColor = Colors.primaryAlt;
                    }

                }
                
                else if(control is PictureBox picture)
                {
                    if (picture.Name == "illustrationPanel")
                    {
                        picture.BackColor = Colors.primaryAlt;
                       
                    }
                }else if(control is TextBox textbox)
                {
                    ApplyTextBoxTheme(textbox);
                }else if(control is Label label)
                {
                    if (label.Name == "lbl_greeting")
                    {
                        ApplyLabelTheme(label, "Bold", 20);
                    }
                    ApplyLabelTheme(label,"Regular");
                }
                
            }
            form.BackColor = Colors.mainBg;
            form.ForeColor = Colors.mainFore;
        }
        public static void ApplyButtonTheme(Button button,string state = null)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            FontConverter converter = new FontConverter();
            button.Font = new Font(converter.ConvertFromString(Resources.Montserrat_Regular.ToString()) as Font, FontStyle.Regular);
            if (state != null)
            {
                switch (state)
                {
                    case "success":
                        button.BackColor = Colors.success;
                        button.FlatAppearance.MouseOverBackColor = Colors.buttonSuccessHover;
                        button.FlatAppearance.MouseDownBackColor = Colors.buttonSuccessPressed;
                        break;
                    case "secondary":
                        button.BackColor = Colors.secondary;
                        button.FlatAppearance.MouseOverBackColor = Colors.buttonSuccessHover;
                        button.FlatAppearance.MouseDownBackColor = Colors.buttonSuccessPressed;
                        break;
                    case "warning":
                        button.BackColor = Colors.warning;
                        button.FlatAppearance.MouseOverBackColor = Colors.buttonWarningHover;
                        button.FlatAppearance.MouseDownBackColor = Colors.buttonWarningPressed;
                        break;
                    case "danger":
                        button.BackColor = Colors.danger;
                        button.FlatAppearance.MouseOverBackColor = Colors.buttonDangerHover;
                        button.FlatAppearance.MouseDownBackColor = Colors.buttonDangerPressed;
                        break;
                    case "info":
                        button.BackColor = Colors.info;
                        button.FlatAppearance.MouseOverBackColor = Colors.buttonSuccessHover;
                        button.FlatAppearance.MouseDownBackColor = Colors.buttonSuccessPressed;
                        break;
                }
            }
            else
            {
                button.BackColor = Colors.buttonPrimary;
                button.FlatAppearance.MouseOverBackColor = Colors.buttonPrimaryHover;
                button.FlatAppearance.MouseDownBackColor = Colors.buttonPrimaryPressed;
                button.ForeColor = Color.White;
            }
        }
       public static void ApplyLabelTheme(Label label,string style,int size = 9)
        {
            FontConverter converter = new FontConverter();
            switch (style)
            {
                case "Bold":
                    label.Font = new Font(Resources.Montserrat_Bold.ToString(),size, FontStyle.Bold);

                    break;
                case "Regular":
                    label.Font = new Font(Resources.Montserrat_Regular.ToString(), size, FontStyle.Regular);
                    break;
            }
               
        }
        public static void ApplyTextBoxTheme(TextBox textBox)
        {
          
            FontConverter converter = new FontConverter();
            textBox.Font = new Font(converter.ConvertFromString(Resources.Montserrat_Regular.ToString()) as Font, FontStyle.Regular);
        }
    }
}

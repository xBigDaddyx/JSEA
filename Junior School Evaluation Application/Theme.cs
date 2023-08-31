using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior_School_Evaluation_Application
{
    public class Theme
    {
        public static Color primary = Color.FromArgb(105, 65, 198);
        public static Color secondary = Color.FromArgb(125, 116, 99);
        public static Color success = Color.FromArgb(152, 216, 170);
        public static Color danger = Color.FromArgb(255, 109, 96);
        public static Color info = Color.FromArgb(25, 167, 206);
        public static Color warning = Color.FromArgb(247, 208, 96);
        public static Color NavButtonHover = Color.FromArgb(127, 86, 217);
        public static Color NavButtonActive = primary;
        public static Color NavButtonIdle = Color.FromArgb(83, 56, 158);
        public static Color MainBg = Color.FromArgb(246, 244, 235);
        public static Color headerGridMain = Theme.primary;
        public static Color headerGridHover = Color.FromArgb(127, 86, 217);
        public static Color gridMain = primary;
        public static Color gridHover = Color.FromArgb(208, 191, 255);
        public static Color gridFore = Color.FromArgb(43, 39, 48);
    }
}

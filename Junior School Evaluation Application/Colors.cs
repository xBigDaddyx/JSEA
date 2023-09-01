using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junior_School_Evaluation_Application
{
    public class Colors
    {
        //conditional colors
        public static Color primary = Color.FromArgb(105, 65, 198);
        public static Color primaryAlt = Color.FromArgb(120, 84, 204);
        public static Color primaryAlt2 = Color.FromArgb(84, 52, 158);
        public static Color secondary = Color.FromArgb(125, 116, 99);
        public static Color success = Color.FromArgb(203, 255, 169);
        public static Color danger = Color.FromArgb(255, 109, 96);
        public static Color info = Color.FromArgb(25, 167, 206);
        public static Color warning = Color.FromArgb(247, 208, 96);

        //main
        public static Color mainBg = Color.FromArgb(246, 244, 235);
        public static Color mainFore = Color.FromArgb(4, 13, 18);
        public static Color mainForeAlt = mainBg;

        //button
        public static Color buttonPrimary = primary;
        public static Color buttonPrimaryHover = Color.FromArgb(120, 84, 204);
        public static Color buttonPrimaryPressed = Color.FromArgb(84, 52, 158);
        public static Color buttonSuccess = success;
        public static Color buttonSuccessHover = Color.FromArgb(213, 255, 186);
        public static Color buttonSuccessPressed = Color.FromArgb(183, 230, 152);
        public static Color buttonWarning = warning;
        public static Color buttonWarningHover = Color.FromArgb(248, 213, 112);
        public static Color buttonWarningPressed = Color.FromArgb(222, 187, 86);
        public static Color buttonDanger = danger;
        public static Color buttonDangerHover = Color.FromArgb(255, 165, 165);
        public static Color buttonDangerPressed = Color.FromArgb(230, 140, 140);
        public static Color buttonInfo = danger;
        public static Color buttonInfoHover = Color.FromArgb(48, 176, 211);
        public static Color buttonInfoPressed = Color.FromArgb(23, 150, 185);
    }
}

using Junior_School_Evaluation_Application.Auth.Models;
using Junior_School_Evaluation_Application.Auth.Services;
using Junior_School_Evaluation_Application.Auth.Views;
using System;
using System.Windows.Forms;

namespace Junior_School_Evaluation_Application
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Teachers teacherModel = new Teachers();

            TeacherServices teacherService = new TeacherServices(teacherModel, DatabaseUtility.GetConnectionString());
            Login loginForm = new Login(teacherService);

            teacherService.Initialize(loginForm);

            Application.Run(loginForm);
        }
    }
}

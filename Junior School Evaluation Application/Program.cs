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

            //TeacherServices teacherService = new TeacherServices(teacherModel, DatabaseUtility.getConnectionString());
            //Login loginForm = new Login(teacherService);

            //teacherService.Initialize(loginForm);
            TeacherRegisterService registerService = new TeacherRegisterService(teacherModel, DatabaseUtility.getConnectionString());
            bool registered = registerService.CheckRegistered();
            //bool registered =true;
            if (registered)
            {
            
                TeacherServices teacherService = new TeacherServices(teacherModel, DatabaseUtility.getConnectionString());
                Login loginForm = new Login(teacherService);

                teacherService.Initialize(loginForm);
                Application.Run(loginForm);
            }
            else
            {
                Register registerForm = new Register(registerService);
                registerService.Initialize(registerForm);

                Application.Run(registerForm);
            }


           
        }
    }
}

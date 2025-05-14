namespace HospitalManagementSystem;

using System.Data.Entity;
using HospitalManagementSystem.View;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Controller;


internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var authController = new AuthController();

        Application.Run(new LoginForm(authController));
    }
}
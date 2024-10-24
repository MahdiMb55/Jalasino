using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Jalasino
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseFacade facade = new DatabaseFacade(new DataContex());
            facade.EnsureCreated();
            using (var context = new DataContex())
            {
                DataSeeder.Seed(context);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

    }
}
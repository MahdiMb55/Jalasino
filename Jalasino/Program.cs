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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

    }
}
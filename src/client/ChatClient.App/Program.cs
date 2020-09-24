using ChatClient.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace ChatClient.App
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceProvider service = Startup.ConfigureServices().BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmChat(service.GetService<IChatService>()));
        }
    }
}

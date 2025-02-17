using Microsoft.Extensions.DependencyInjection;
using SchoolPoliApp.WinForms.Service;
using System;
using System.Windows.Forms.Design;

namespace SchoolPoliApp.WinForms
{
    internal static class Program
    {
        private static ServiceProvider serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            // Configure DI
            var services = new ServiceCollection();
            ConfigureServices(services);

            serviceProvider = services.BuildServiceProvider();
           
            // Get MainForm from DI container
            var mainForm = serviceProvider.GetRequiredService<Form1>();

            Application.Run(mainForm);
                       
           
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            
            // Register application services
            services.AddSingleton<IMyService, MyService>();

            // Register the main form with DI
            services.AddTransient<Form1>();
        }
    }
}
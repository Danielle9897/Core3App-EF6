using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Core3App_EF6
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Workaround from: https://devblogs.microsoft.com/dotnet/announcing-entity-framework-6-3-preview-with-net-core-support/
            // I am not sure why this is needed - can do w/o as well.
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);

            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
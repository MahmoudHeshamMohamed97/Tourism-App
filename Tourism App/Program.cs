using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Data_Context _dbContext;
        [STAThread]
        static void Main()
        {
            _dbContext = new Data_Context();
            Database.SetInitializer<Data_Context>(new MigrateDatabaseToLatestVersion<Data_Context, Migrations.Configuration>() );


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
             
        }
    }
}

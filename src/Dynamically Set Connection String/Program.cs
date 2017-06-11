using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Impendulo.DatabaseSettings.Development;
using Dynamically_Set_Connection_String.Database_Enumeration;

namespace Impendulo.DatabaseConnection.Development
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDynamicallySetConnectionString());
        }
    }
}

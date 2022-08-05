using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DL.GlobalVariables.load();
            DL.UserCRUD.load();
            DL.ProductCRUD.load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var v = new LoginForm();
            Application.Run(v);
        }
    }
}

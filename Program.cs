using DOAN._Class;
using DOAN._controllManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
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
            List<Manager> managers = new List<Manager>();
            List<Receptionist> receptionists = new List<Receptionist>();
            Application.Run(new Base_Form());
        }
    }
}

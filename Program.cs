using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundDominator_v2
{
    internal static class Program
    {
        public static List<string> strUsados = new List<string>();
        public static List<int> intVeces = new List<int>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }


        
    }
}

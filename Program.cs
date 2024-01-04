using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimijenjenaMatematika_DC.Forms;

namespace PrimijenjenaMatematika_DC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

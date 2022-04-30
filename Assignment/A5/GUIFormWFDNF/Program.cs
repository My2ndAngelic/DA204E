using System;
using System.Windows.Forms;

namespace GUIFormWFDNF
{
    public class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        ///     Possibly can be run on Windows XP
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}

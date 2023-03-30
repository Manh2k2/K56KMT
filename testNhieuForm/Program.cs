using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testNhieuForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static public Form1 papa;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(papa=new Form1());
        }
    }
}

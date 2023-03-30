using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace testNhieuForm
{
    internal static class Program
    {
        static public Form1 papa;  //lưu form1 khi bắt đầu chạy
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //gán new Form1() cho biến papa, ko phải là toán tử so sánh nhé
            Application.Run(papa=new Form1()); 
        }
    }
}

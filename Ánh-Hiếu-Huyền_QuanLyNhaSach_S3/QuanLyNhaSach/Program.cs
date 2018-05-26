using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //FormLoad f = new FormLoad();
            //f.ShowDialog();
            //if (f.DialogResult == DialogResult.OK)
            //{
            //    Application.Run(new frmNhanVien());
            //}
            Application.Run(new KH());
        }
    }
}

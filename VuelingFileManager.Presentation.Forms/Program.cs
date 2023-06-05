using System;
using System.Windows.Forms;
using VuelingFileManager.Business;
using VuelingFileManager.Transversal;

namespace VuelingFileManager.Presentation.Form
{
    internal static class Program
    {
        /// <summary>
        /// 
        /// VERSION 1.1
        /// CODE MADE BY MIQUEL T.
        /// 06/06/2023
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}

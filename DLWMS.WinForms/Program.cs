using DLWMS.WinForms.P10;
using DLWMS.WinForms.P4;
using DLWMS.WinForms.P5;
using DLWMS.WinForms.P6;
using DLWMS.WinForms.P7;
using DLWMS.WinForms.P8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
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
            Form forma = new frmStudenti();
            Application.Run(forma);
        }
    }
}

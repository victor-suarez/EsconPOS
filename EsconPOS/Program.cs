using System;
using System.Windows.Forms;

namespace EsconPOS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new forms.FrmEntrada());
            if (classes.Global.LoggedIN)
                Application.Run(new forms.MDIEsconPos());
        }
    }
}
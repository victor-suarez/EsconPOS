using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EsconPOS
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
            Application.Run(new forms.FrmEntrada());
            if(classes.Global.LoggedIN)
                Application.Run(new forms.MDIEsconPos());
        }
    }
}

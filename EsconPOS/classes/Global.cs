using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsconPOS.classes
{
    class Global
    {
        private static bool _LoggedIN;
        private static Usuarios _Usuario;
        private static Empleados _Empleado;
        private static Cajas _Caja;
        private static Empresas _Empresa;
        public static bool LoggedIN
        {
            get { return _LoggedIN; }
            set { _LoggedIN = value; }
        }
        public static Usuarios Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public static Empleados Empleado
        {
            get { return _Empleado; }
            set { _Empleado = value; }
        }
        public static Cajas Caja
        {
            get { return _Caja; }
            set { _Caja = value; }
        }
        public static Empresas Empresa
        {
            get { return _Empresa; }
            set { _Empresa = value; }
        }

        internal static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public static void MensajeError(Exception ex, string Msj = "")
        {
            MessageBox.Show(ex.Source + "\r\n" + ex.Message, Msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MensajeErrorBd(Exception ex, string Msj = "")
        {
            var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                          .SelectMany(ve => ve.ValidationErrors)
                                                                                          .Select(ve => ve.ErrorMessage);
            var fullErrorMessage = string.Join("; ", DbErrors);
            MessageBox.Show(fullErrorMessage, Msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

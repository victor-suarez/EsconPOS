using System;
using System.Linq;
using System.Windows.Forms;

namespace EsconPOS.classes
{
    internal class Global
    {
        #region Variables privadas

        private static bool _CambiarContrasenia = false;
        private static string _CnxStr;
        private static bool _LoggedIN;
        private static bool EsAdministrador;
        private static long ID_Caja;
        private static long ID_DistritoEmpresa;
        private static long ID_Empleado;
        private static long ID_Empresa;
        private static long ID_Usuario;
        private static string NomCaja;
        private static string NomEmpleado;
        private static string NomEmpresa;

        #endregion Variables privadas

        #region Objetos privados

        private static Cajas _Caja;
        private static Empleados _Empleado;
        private static Empresas _Empresa;
        private static Usuarios _Usuario;

        #endregion Objetos privados

        #region Propiedades públicas

        public static Cajas Caja
        {
            get { return _Caja; }
            set { _Caja = value; }
        }

        public static bool CambiarContrasenia
        {
            get { return _CambiarContrasenia; }
            set { _CambiarContrasenia = value; }
        }

        public static string CnxStr
        {
            get { return _CnxStr; }
            set { _CnxStr = value; }
        }

        public static Empleados Empleado
        {
            get { return _Empleado; }
            set { _Empleado = value; }
        }

        public static Empresas Empresa
        {
            get { return _Empresa; }
            set { _Empresa = value; }
        }

        public static long glCaja
        {
            get { return ID_Caja; }
            set { ID_Caja = value; }
        }

        public static long glDistritoEmpresa
        {
            get { return ID_DistritoEmpresa; }
            set { ID_DistritoEmpresa = value; }
        }

        public static long glEmpleado
        {
            get { return ID_Empleado; }
            set { ID_Empleado = value; }
        }

        public static long glEmpresa
        {
            get { return ID_Empresa; }
            set { ID_Empresa = value; }
        }

        public static bool glEsAdministrador
        {
            get { return EsAdministrador; }
            set { EsAdministrador = value; }
        }

        public static string glNomCaja
        {
            get { return NomCaja; }
            set { NomCaja = value; }
        }

        public static string glNomEmpleado
        {
            get { return NomEmpleado; }
            set { NomEmpleado = value; }
        }

        public static string glNomEmpresa
        {
            get { return NomEmpresa; }
            set { NomEmpresa = value; }
        }

        public static long glUsuario
        {
            get { return ID_Usuario; }
            set { ID_Usuario = value; }
        }

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

        #endregion Propiedades públicas

        #region Funciones públicas

        public static void MensajeError(Exception ex, string Msj = "")
        {
            if (ex.Source == "EntityFramework")
            {
                if (ex.Message.Contains("EntityValidationErrors") && ex.InnerException == null)
                    MensajeErrorVal(ex, Msj);
                else
                    MensajeErrorBd(ex.InnerException, Msj);
            }
            else
                MensajeErrorApp(ex, Msj);
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

        #endregion Funciones públicas

        #region Funciones privadas

        private static void MensajeErrorApp(Exception ex, string Msj = "")
        {
            MessageBox.Show(ex.Source + "\r\n" + ex.Message, Msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void MensajeErrorBd(Exception ex, string Msj = "")
        {
            Exception InnerEx = ex.InnerException ?? ex;
            if (InnerEx.Source == "System.Data.SQLite")
            {
                MessageBox.Show(InnerEx.Message, Msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(ex.Source + "\r\n" + ex.Message, Msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void MensajeErrorVal(Exception ex, string Msj = "")
        {
            var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                          .SelectMany(ve => ve.ValidationErrors)
                                                                                          .Select(ve => ve.ErrorMessage);
            var fullErrorMessage = string.Join("; ", DbErrors);
            MessageBox.Show(fullErrorMessage, Msj, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Funciones privadas
    }
}
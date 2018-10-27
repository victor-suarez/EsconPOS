using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class Empleados
    {
        private Datos _Conx;
        Dictionary<string, string> record;
        List<object> recordset;

        private readonly int _EmpleadoID;
        private readonly int _IdentificacionID;
        private readonly string _NroDocIdent;
        private readonly string _Nombre;
        private readonly string _Direccion;
        private readonly string _Telefonos;
        private readonly string _CorreoElectronico;
        private readonly string _Login;
        private readonly byte[] _Password;
        private readonly bool _EsSupervisor;
        private readonly bool _EsAdministrador;

        public int EmpleadoID { get => _EmpleadoID; }
        public int IdentificacionID { get => _IdentificacionID; }
        public string NroDocIdent { get => _NroDocIdent; }
        public string Nombre { get => _Nombre; }
        public string Direccion { get => _Direccion; }
        public string Telefonos { get => _Telefonos; }
        public string CorreoElectronico { get => _CorreoElectronico; }
        public string Login { get => _Login; }
        public byte[] Password { get; }
        public bool EsSupervisor { get => _EsSupervisor; }
        public bool EsAdministrador { get => _EsAdministrador; }

        public Empleados(Datos Conx)
        {
            _Conx = Conx;
        }
        public Empleados(int EmpleadoID, int IdentificacionID, string NroDocIdent, string Nombre,
                         string Direccion, string Telefonos, string CorreoElectronico,
                         bool EsSupervisor, bool EsAdministrador)
        {
            _EmpleadoID = EmpleadoID;
            _IdentificacionID = IdentificacionID;
            _NroDocIdent = NroDocIdent;
            _Nombre = Nombre;
            _Direccion = Direccion;
            _Telefonos = Telefonos;
            _CorreoElectronico = CorreoElectronico;
            _EsSupervisor = EsSupervisor;
            _EsAdministrador = EsAdministrador;
        }
        public bool EmpleadoAdminDefinido()
        {
            string sql = "SELECT COUNT(*) AS EmpleadoAdminDefinido FROM Empleados WHERE EsAdministrador=1;";
            try
            {
                recordset = _Conx.ExecActionQry(sql);
                record = (Dictionary<string, string>)recordset[0];
                return (int.Parse(record["EmpleadoAdminDefinido"]) > 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Empleados Entrada(string Login, string Password)
        {
            string sql = "SELECT * FROM Empleados WHERE Login='" + Login + "' AND PasswdHash='" + GetStringSha256Hash(Password) + "'";
            try
            {
                recordset = _Conx.ExecActionQry(sql);
                if (recordset.Count < 1)
                {
                    throw new Exception("Usuario no defnido en el sistema.");
                }
                // Sólo puede haber uno!
                record = (Dictionary<string, string>)recordset[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new Empleados(int.Parse(record["EmpleadoID"]),
                                 int.Parse(record["IdentificacionID"]),
                                 record["NroDocIdent"],
                                 record["Nombre"],
                                 record["Direccion"],
                                 record["Telefonos"],
                                 record["CorreoElectronico"],
                                 int.Parse(record["EsSupervisor"]) == 1,
                                 int.Parse(record["EsAdministrador"]) == 1);
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
        public override string ToString()
        {
            return Nombre;
        }
    }
}


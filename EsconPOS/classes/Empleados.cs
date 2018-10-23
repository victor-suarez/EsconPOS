using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class Empleados
    {
        public int EmpleadoID { get; set; }
        public int IdentificacionID { get; set; }
        public string NroDocIdent { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public bool EsSupervisor { get; set; }
        public bool EsAdministrador { get; set; }

        public Empleados()
        {
        }
        public Empleados(int _EmpleadoID, int _IdentificacionID, string _NroDocIdent, string _Nombre,
                         string _Direccion, string _Telefonos, string _CorreoElectronico,
                         bool _EsSupervisor, bool _EsAdministrador)
        {
            EmpleadoID = _EmpleadoID;
            IdentificacionID = _IdentificacionID;
            NroDocIdent = _NroDocIdent;
            Nombre = _Nombre;
            Direccion = _Direccion;
            Telefonos = _Telefonos;
            CorreoElectronico = _CorreoElectronico;
            EsSupervisor = _EsSupervisor;
            EsAdministrador = _EsAdministrador;
        }
        public Empleados Entrada(string Login, string Password, Datos CDatos)
        {
            string sql = "SELECT * FROM Empleados WHERE Login='" + Login + "' AND PasswdHash='" + GetStringSha256Hash(Password) + "'";
            try
            {
                List<object> recordset = CDatos.ExecActionQry(sql);
                Dictionary<string, string> record = new Dictionary<string, string>();
                Empleados emp;
                if (recordset.Count < 1)
                {
                    throw new Exception("Usuario o contraseña inválido.");
                }
                Dictionary<string, string> rec = (Dictionary<string, string>)recordset[0];
                emp = new Empleados(int.Parse(rec["EmpleadoID"]),
                                    int.Parse(rec["IdentificacionID"]),
                                    rec["NroDocIdent"].ToString(),
                                    rec["Nombre"].ToString(),
                                    rec["Direccion"].ToString(),
                                    rec["Telefonos"].ToString(),
                                    rec["CorreoElectronico"].ToString(),
                                    int.Parse(rec["EsSupervisor"]) == 1,
                                    int.Parse(rec["EsAdministrador"]) == 1);
                return emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }

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
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class Empleados
    {
        //private Datos _Conx;
        //Dictionary<string, string> record;
        //List<object> recordset;

        //private readonly int _EmpleadoID;
        //private readonly int _IdentificacionID;
        //private readonly string _NroDocIdent;
        //private readonly string _Nombre;
        //private readonly string _Direccion;
        //private readonly string _Telefonos;
        //private readonly string _CorreoElectronico;
        //private readonly bool _EsSupervisor;
        //private readonly bool _EsAdministrador;

        public int EmpleadoID { get; set; }
        public int IdentificacionID { get; set; }
        public string NroDocIdent { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public string CorreoElectronico { get; set; }
        public bool EsSupervisor { get; set; }
        public bool EsAdministrador { get; set; }
        public virtual Identificaciones Identificaciones { get; set; }

        //public Empleados(Datos Conx)
        //{
        //    _Conx = Conx;
        //}

        //public Empleados(int EmpleadoID, int IdentificacionID, string NroDocIdent, string Nombre,
        //                 string Direccion, string Telefonos, string CorreoElectronico,
        //                 bool EsSupervisor, bool EsAdministrador)
        //{
        //    _EmpleadoID = EmpleadoID;
        //    _IdentificacionID = IdentificacionID;
        //    _NroDocIdent = NroDocIdent;
        //    _Nombre = Nombre;
        //    _Direccion = Direccion;
        //    _Telefonos = Telefonos;
        //    _CorreoElectronico = CorreoElectronico;
        //    _EsSupervisor = EsSupervisor;
        //    _EsAdministrador = EsAdministrador;
        //}

        //public bool EmpleadoAdminDefinido()
        //{
        //    string sql = "SELECT COUNT(*) AS EmpleadoAdminDefinido FROM Empleados WHERE EsAdministrador=1;";
        //    try
        //    {
        //        recordset = _Conx.ExecActionQry(sql);
        //        record = (Dictionary<string, string>)recordset[0];
        //        return (int.Parse(record["EmpleadoAdminDefinido"]) > 0);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public Empleados Entrada(string Login, string Password)
        //{
        //    string sql = "SELECT * FROM Empleados WHERE Login='" + Login + "' AND PasswdHash='" + GetStringSha256Hash(Password) + "';";
        //    try
        //    {
        //        recordset = _Conx.ExecActionQry(sql);
        //        if (recordset.Count < 1)
        //        {
        //            return null;
        //        }
        //        // Sólo puede haber uno!
        //        record = (Dictionary<string, string>)recordset[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex.InnerException;
        //    }
        //    return new Empleados(int.Parse(record["EmpleadoID"]),
        //                         int.Parse(record["IdentificacionID"]),
        //                         record["NroDocIdent"],
        //                         record["Nombre"],
        //                         record["Direccion"],
        //                         record["Telefono"],
        //                         record["CorreoElectronico"],
        //                         int.Parse(record["EsSupervisor"]) == 1,
        //                         int.Parse(record["EsAdministrador"]) == 1);
        //}

        //public bool Agregar(int IdentificacionID,string NroDocIdent, string Nombre, string Direccion,
        //                    string Telefono, string CorreoE, string Login, string Password,
        //                    bool EsSupervisor, bool EsAdministrador)
        //{
        //    string sql = "INSERT INTO Empleados(IdentificacionID,NroDocIdent,Nombre,Direccion,Telefono,CorreoElectronico,Login,PasswdHash,EsSupervisor,EsAdministrador) VALUES(";
        //    sql += IdentificacionID.ToString() + ",";
        //    sql += StrParamFormatted(NroDocIdent) + ",";
        //    sql += StrParamFormatted(Nombre) + ",";
        //    sql += StrParamFormatted(Direccion) + ",";
        //    sql += StrParamFormatted(Telefono) + ",";
        //    sql += StrParamFormatted(CorreoE) + ",";
        //    sql += StrParamFormatted(Login) + ",";
        //    sql += StrParamFormatted(GetStringSha256Hash(Password)) + ",";
        //    sql += (EsSupervisor ? "1," : "0,");
        //    sql += (EsAdministrador ? "1," : "0");
        //    sql += ")";
        //    string[] Parameters = { "@IdentificacionID",
        //                            "@NroDocIdent",
        //                            "@Nombre",
        //                            "@Direccion",
        //                            "@Telefono",
        //                            "@CorreoElectronico",
        //                            "@Login",
        //                            "@PasswdHash",
        //                            "@EsSupervisor",
        //                            "@EsAdministrador" };
        //    string[] Values = { IdentificacionID.ToString(),
        //                        NroDocIdent,
        //                        Nombre,
        //                        Direccion,
        //                        Telefono,
        //                        CorreoElectronico,
        //                        Login,
        //                        StrParamFormatted(GetStringSha256Hash(Password)),
        //                        EsSupervisor.ToString(),
        //                        EsAdministrador.ToString() };
        //    try
        //    {
        //        int rec = _Conx.ExecNonActionQry("INSERT", "Empleados", Parameters, Values);
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex.InnerException;
        //    }
        //    return true;
        //}

        //public bool Modificar(int EmpleadoID, int IdentificacionID, string NroDocIdent, string Nombre,
        //                      string Direccion, string Telefonos, string CorreoE, bool EsSupervisor,
        //                      bool EsAdministrador)
        //{
        //    string sql = "UPDATE Empleados SET ";
        //    sql += IdentificacionID.ToString() + ",";
        //    sql += "'" + StrParamFormatted(NroDocIdent) + "',";
        //    sql += "'" + StrParamFormatted(Nombre) + "',";
        //    sql += "'" + StrParamFormatted(Direccion) + "',";
        //    sql += "'" + StrParamFormatted(Telefonos) + "',";
        //    sql += "'" + StrParamFormatted(CorreoE) + "',";
        //    sql += (EsSupervisor ? "1," : "0,");
        //    sql += (EsAdministrador ? "1," : "0");
        //    sql += ")";
        //    string[] Parameters =
        //                        {
        //                            "EmpleadoID",
        //                            "IdentificacionID",
        //                            "NroDocIdent",
        //                            "Nombre",
        //                            "Direccion",
        //                            "Telefono",
        //                            "CorreoElectronico",
        //                            "EsSupervisor",
        //                            "EsAdministrador"
        //                        };
        //    string[] Values =
        //                    {
        //                        EmpleadoID.ToString(),
        //                        IdentificacionID.ToString(),
        //                        NroDocIdent,
        //                        Nombre,
        //                        Direccion,
        //                        Telefonos,
        //                        CorreoE,
        //                        EsSupervisor.ToString(),
        //                        EsAdministrador.ToString()
        //                    };
        //    try
        //    {
        //        int rec = _Conx.ExecNonActionQry("UPDATE", "Empleados", Parameters, Values);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex.InnerException;
        //    }
        //    return true;
        //}

        //public bool Eliminar(int EmpleadoID)
        //{
        //    string[] Parameters = { "EmpleadoID" };
        //    string[] Values = { EmpleadoID.ToString() };
        //    try
        //    {
        //        int rec = _Conx.ExecNonActionQry("DELETE", "Empleados", Parameters, Values);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex.InnerException;
        //    }
        //    return true;
        //}

        //public bool CambiarPassword(int EmpleadoID, string Login, string Password)
        //{
        //    string[] Parameters = { "EmpleadoID", "Login", "PasswdHash" };
        //    string[] Values = { EmpleadoID.ToString(), Login, StrParamFormatted(GetStringSha256Hash(Password)) };
        //    try
        //    {
        //        int rec = _Conx.ExecNonActionQry("UPDATE", "Empleados", Parameters, Values);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex.InnerException;
        //    }
        //    return true;
        //}

        //private string StrParamFormatted(string StrVal)
        //{
        //    if (StrVal.Trim() == "")
        //        return "NULL";
        //    else
        //        return "'" + StrVal + "'";
        //}

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

        //public override string ToString()
        //{
        //    return Nombre;
        //}
    }
}


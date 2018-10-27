using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class Identificaciones
    {
        private Datos _Conx;
        private List<object> recordset;
        private Dictionary<string, string> record;

        private int _IdentificacionID;
        private string _Codigo;
        private string _Identificacion;
        private string _Iniciales;
        public int IdentificacionID { get => _IdentificacionID; }
        public string Codigo { get => _Codigo; }
        public string Identificacion { get => _Identificacion; }
        public string Iniciales { get => _Iniciales; }
        public Identificaciones(Datos Conx)
        {
            _Conx = Conx;
        }
        public Identificaciones(string Codigo, string Identificacion, string Iniciales)
        {
            _Codigo = Codigo;
            _Identificacion = Identificacion;
            _Iniciales = Iniciales;
        }
        public Identificaciones(int IdentificacionID, string Codigo, string Identificacion, string Iniciales)
        {
            _IdentificacionID = IdentificacionID;
            _Codigo = Codigo;
            _Identificacion = Identificacion;
            _Iniciales = Iniciales;
        }
        public bool Agregar(string Codigo, string Identificacion, string Iniciales)
        {
            string sql = "INSERT INTO Identificaciones(Codigo,Identificacion,Iniciales) VALUES(";
            sql += "'" + Codigo + "',";
            sql += "'" + Identificacion + "',";
            sql += "'" + Iniciales + "');";
            try
            {
                int rec = _Conx.ExecNonActionQry(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool Modificar(int IdentificacionID, string Codigo, string Identificacion, string Iniciales)
        {
            string sql = "UPDATE Identificaciones SET";
            sql += " Codigo='" + Codigo + "'";
            sql += ",Identificacion='" + Identificacion + "'";
            sql += ",Iniciales='" + Iniciales + "'";
            sql += " WHERE IdentificacionID=" + IdentificacionID.ToString() + ";";
            try
            {
                int rec = _Conx.ExecNonActionQry(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool Eliminar(int IdentificacionID)
        {
            string sql = "DELETE FROM Identificaciones WHERE IdentificacionID=" + IdentificacionID.ToString() + ";";
            try
            {
                int rec = _Conx.ExecNonActionQry(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public List<Identificaciones> Listar(int IdentificacionID = -1)
        {
            List<Identificaciones> Lista = new List<Identificaciones>();

            string sql = "SELECT * FROM Identificaciones";
            if(IdentificacionID != -1) sql += " WHERE IdentificacionID=" + IdentificacionID.ToString();
            sql += ";";
            recordset = _Conx.ExecActionQry(sql);
            foreach (object rec in recordset)
            {
                record = (Dictionary<string, string>)rec;
                Lista.Add(new Identificaciones(int.Parse(record["IdentificacionID"]),
                                               record["Codigo"],
                                               record["Identificacion"],
                                               record["Iniciales"]));
            }
            return Lista;
        }
        public override string ToString()
        {
            return Codigo + '-' + Identificacion;
        }

    }
}

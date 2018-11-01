using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class Cajas
    {
        private Datos _Conx;
        List<object> recordset;
        Dictionary<string, string> record;

        private const short TR_APERTURA_CAJA = 1;
        private const short TR_CIERRE_CAJA = 4;

        private readonly int _CajaID;
        private readonly string _Descripcion;

        public int CajaID { get { return _CajaID; } }
        public string Descripcion { get { return _Descripcion; } }
        public bool Abierta { get; private set; }
        public DateTime FechaHoraEstado { get; private set; }

        public Cajas(Datos Conx)
        {
            _Conx = Conx;
        }

        public Cajas(int CajaID, string Descripcion)
        {
            _CajaID = CajaID;
            _Descripcion = Descripcion;
            Abierta = true;
            FechaHoraEstado = DateTime.Now;
        }

        public Cajas Buscar()
        {
            string sql = "SELECT CajaID,Descripcion FROM Cajas;";
            try
            {
                recordset = _Conx.ExecActionQry(sql);
                if (recordset.Count < 1)
                {
                    throw new Exception("Caja no está definida.");
                }
                // Sólo puede haber una!
                record = (Dictionary<string, string>)recordset[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new Cajas(int.Parse(record["CajaID"]), record["Descripcion"]);
        }

        public void AbrirCaja(int EmpleadoID)
        {
            // Ups!
            if (Abierta)
                throw new Exception("La caja ya está abierta.");

            // Loggeo la transacción de apertura de caja.
            //string sql = "INSERT INTO CajaLog(CajaID,TransaccionID,EmpleadoID) VALUES(";
            //sql += CajaID.ToString() + ",";
            //sql += TR_APERTURA_CAJA.ToString() + ",";
            //sql += EmpleadoID.ToString() + ");";
            try
            {
                string[] Parameters = { "@CajaID", "@TransaccionID", "@EmpleadoID" };
                string[] Values = { CajaID.ToString(), TR_APERTURA_CAJA.ToString(), EmpleadoID.ToString() };
                int rec = _Conx.ExecNonActionQry("INSERT","CajaLog", Parameters, Values);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            Abierta = true;
            FechaHoraEstado = DateTime.Now;
        }
        public void CerrarCaja(int EmpleadoID)
        {
            // Ups!
            if (!Abierta)
                throw new Exception("La caja ya está cerrada.");

            // Loggeo la transacción de cierre de caja.
            //string sql = "INSERT INTO CajaLog(CajaID,TransaccionID,EmpleadoID) VALUES(";
            //sql += CajaID.ToString() + ",";
            //sql += TR_CIERRE_CAJA.ToString() + ",";
            //sql += EmpleadoID.ToString() + ");";
            try
            {
                string[] Parameters = { "@CajaID", "@TransaccionID", "@EmpleadoID" };
                string[] Values = { CajaID.ToString(), TR_CIERRE_CAJA.ToString(), EmpleadoID.ToString() };
                int rec = _Conx.ExecNonActionQry("INSERT", "CajaLog", Parameters, Values);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Abierta = false;
            FechaHoraEstado = DateTime.Now;
        }
        public bool Agregar(int CajaID, string Descripcion)
        {
            //string sql = "INSERT INTO Cajas(CajaID,Descripcion) VALUES(";
            //sql += CajaID.ToString() + ",";
            //sql += "'" + Descripcion + "');";
            try
            {
                string[] Parameters = { "@CajaID", "@Descripcion" };
                string[] Values = { CajaID.ToString(), Descripcion };
                int rec = _Conx.ExecNonActionQry("INSERT", "Cajas", Parameters, Values);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public override string ToString()
        {
            return CajaID.ToString("00") + "-" + Descripcion;
        }
    }
}

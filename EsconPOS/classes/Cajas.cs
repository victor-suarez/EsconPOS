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
        private List<object> recordset;
        private readonly Dictionary<string, string> record;

        private const short TR_APERTURA_CAJA = 1;
        private const short TR_CIERRE_CAJA = 4;

        private readonly int _CajaID;
        private readonly string _Descripcion;
        private DateTime _FechaHoraEstado;
        public int CajaID { get => _CajaID; }
        public string Descripcion { get => _Descripcion; }
        public bool Abierta { get; private set; }
        public DateTime FechaHoraEstado { get => _FechaHoraEstado; }

        public Cajas(Datos Conx)
        {
            _Conx = Conx;
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
            _CajaID = int.Parse(record["CajaID"]);
            _Descripcion = record["Descripcion"];
        }
        public Cajas(int CajaID, string Descripcion)
        {
            _CajaID = CajaID;
            _Descripcion = Descripcion;
            Abierta = true;
            _FechaHoraEstado = DateTime.Now;
        }
        public void AbrirCaja(int EmpleadoID)
        {
            // Ups!
            if (Abierta)
                throw new Exception("La caja ya está abierta.");

            // Loggeo la transacción de apertura de caja.
            string sql = "INSERT INTO CajaLog(CajaID,TransaccionID,EmpleadoID) VALUES(";
            sql += CajaID.ToString() + ",";
            sql += TR_APERTURA_CAJA.ToString() + ",";
            sql += EmpleadoID.ToString() + ");";
            try
            {
                int rec = _Conx.ExecNonActionQry(sql);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            Abierta = true;
            _FechaHoraEstado = DateTime.Now;
        }
        public void CerrarCaja(int EmpleadoID)
        {
            // Ups!
            if (!Abierta)
                throw new Exception("La caja ya está cerrada.");

            // Loggeo la transacción de cierre de caja.
            string sql = "INSERT INTO CajaLog(CajaID,TransaccionID,EmpleadoID) VALUES(";
            sql += CajaID.ToString() + ",";
            sql += TR_CIERRE_CAJA.ToString() + ",";
            sql += EmpleadoID.ToString() + ");";
            try
            {
                int rec = _Conx.ExecNonActionQry(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Abierta = false;
            _FechaHoraEstado = DateTime.Now;
        }
        public override string ToString()
        {
            return CajaID.ToString("00") + "-" + Descripcion;
        }
    }
}

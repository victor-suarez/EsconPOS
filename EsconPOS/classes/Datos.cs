using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace EsconPOS.classes
{
    public class Datos
    {
        private const string CnxStr = "Data Source=./database/EsconPOS.db;Version=3;FailIfMissing=True;Foreign Keys=True;";
        private static SQLiteConnection _Conx = new SQLiteConnection(CnxStr);
        private static readonly Datos _instance;
        private static bool _IsOpen = false;
        public static bool IsOpen => _IsOpen;

        static Datos()
        {
            _instance = new Datos();
        }
        // Abrir conexión a la base de datos.
        public static Datos Conx
        {
            get { return _instance; }
        }
        public void OpenDatabase()
        {
            if (IsOpen) return;
            try
            {
                _Conx.Open();
                _IsOpen = true;
            }
            catch (SQLiteException ex)
            {
                throw new Exception("OpenDatabase", ex);
            }
        }
  
        // Cerrar conexión a la base de datos.
        public void CloseDatabase()
        {
            if (!IsOpen) return;
            try
            {
                _Conx.Close();
                _IsOpen = false;
            }
            catch (SQLiteException ex)
            {
                throw new Exception("CloseDatabase", ex);
            }
        }
        
        // Si el query no devuelve datos (INSERT / UPDATE / DELETE)
        public int ExecNonActionQry(string Query, string Table, string[] Parameters, string[] Values)
        {
            string FullQuery = "";
            if (Query.StartsWith("INSERT"))
            {
                FullQuery = "INSERT INTO " + Table + "(";
                FullQuery += AddParameters(Parameters, "INSERT");
                FullQuery += ") VALUES(";
                FullQuery += AddParameters(Parameters, "@");
                FullQuery += ")";
            }
            else if (Query.StartsWith("UPDATE"))
            {
                FullQuery = "UPDATE " + Table + " SET ";
                FullQuery += AddParameters(Parameters, "UPDATE");
                FullQuery += " WHERE " + Parameters[0] + "=@" + Values[0];
            }
            else if (Query.StartsWith("DELETE"))
            {
                FullQuery = "DELETE " + Table + " WHERE ";
                FullQuery += AddParameters(Parameters, "DELETE");
            }

            try
            {
                SQLiteCommand command = _Conx.CreateCommand();
                command.CommandText = Query;
                command.Prepare();
                for (int i = 0; i <= Values.GetUpperBound(0); i++)
                    command.Parameters.AddWithValue("@" + Parameters[i], Values[i]);

                //SQLiteCommand command = new SQLiteCommand(Query, _Conx);
                return command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw new Exception("ExecNonActionQry", ex);
            }
        }
        
        // Si el query devuelve datos (SELECT)
        public List<object> ExecActionQry(string Query)
        {
            List<object> recset = new List<object>();
            try
            {
                SQLiteCommand command = new SQLiteCommand(Query, _Conx);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<string, string> rec = new Dictionary<string, string>();
                    for (int idx = 0; idx < reader.FieldCount; idx++)
                    {
                        //if(reader.IsDBNull)
                        rec.Add( reader.GetName(idx), reader.GetValue(idx).ToString());
                    }
                    recset.Add(rec);
                }
                // Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
            }
            catch (SQLiteException ex)
            {
                throw new Exception("ExecActionQry", ex);
            }
            return recset;
        }

        string AddParameters(string[] Parameters, string For, string AddPrefix = "")
        {
            string ExtendedQuery = "";
            for (int i = 0; i <= Parameters.GetUpperBound(0); i++)
            {
                if (For == "INSERT")
                    ExtendedQuery += AddPrefix + Parameters[i] + ((i == Parameters.GetUpperBound(0)) ? "" : ",");
                else if (For == "UPDATE")
                    if(i > 0)
                        ExtendedQuery += Parameters[i] + "=" + AddPrefix + Parameters[i] + ((i == Parameters.GetUpperBound(0)) ? "" : ",");
                else if (For == "DELETE")
                    ExtendedQuery += Parameters[i] + "=" + AddPrefix + Parameters[i] + ((i == Parameters.GetUpperBound(0)) ? "" : " AND ");
            }
            return ExtendedQuery;
        }
    }
}

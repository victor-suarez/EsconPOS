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
            try
            {
                _Conx.Open();
            }
            catch (SQLiteException ex)
            {
                throw new Exception("OpenDatabase", ex);
            }
        }
        // Cerrar conexión a la base de datos.
        public void CloseDatabase()
        {
            try
            {
                _Conx.Close();
            }
            catch (SQLiteException ex)
            {
                throw new Exception("CloseDatabase", ex);
            }
        }
        // Si el query no devuelve datos (INSERT / UPDATE / DELETE)
        public int ExecNonActionQry(string Query)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(Query, _Conx);
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
            List<object> RecSet = new List<object>();
            Dictionary<string, string> Rec = new Dictionary<string, string>();
            try
            {
                SQLiteCommand command = new SQLiteCommand(Query, _Conx);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int idx = 0; idx < reader.FieldCount; idx++)
                    {
                        //if(reader.IsDBNull)
                        Rec.Add(reader.GetName(idx), reader.GetValue(idx).ToString());
                    }
                    RecSet.Add(Rec);
                }
                // Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
            }
            catch (SQLiteException ex)
            {
                throw new Exception("ExecActionQry", ex);
            }
            return RecSet;
        }

    }
}

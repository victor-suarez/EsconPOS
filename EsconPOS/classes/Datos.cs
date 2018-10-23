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
        private readonly SQLiteConnection Conx = new SQLiteConnection(CnxStr);
        private bool IsCnxOpen = false;

         // Abrir conexión a la base de datos.
       public Datos()
        {
            try
            {
                if (!IsCnxOpen) Conx.Open();
                IsCnxOpen = true;
            }
            catch (SQLiteException ex)
            {
                IsCnxOpen = false;
                throw new Exception("OpenDatabase", ex);
            }
        }
        // Cerrar conexión a la base de datos.
        public void CloseDatabase()
        {
            try
            {
                Conx.Close();
                IsCnxOpen = false;
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
                SQLiteCommand command = new SQLiteCommand(Query, Conx);
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
                SQLiteCommand command = new SQLiteCommand(Query, Conx);
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

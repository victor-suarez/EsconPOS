using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clsPais
{
    public class Pais
    {
        public int PaisID { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string ISO { get; set; }

        public string Agregar(string Nombre, string Codigo, string ISO)
        {
            int NeoPaisID = 0;
            try
            {
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return NeoPaisID.ToString();
        }
        public string Modificar(int PaisID, string Nombre, string Codigo, string ISO)
        {
            return "";
        }
    }
}

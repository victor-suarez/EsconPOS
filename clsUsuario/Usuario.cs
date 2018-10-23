using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clsUsuario
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool EsAdministrador { get; set; }

        public int Agregar(string Login, string Password, bool EsAdministrador)
        {
            int NeoUsuarioID = 0;
            try
            {
                string sql = "SELECT * FROM Usuarios WHERE Login='" + Login + "' AND PasswdHash='" + Password + "'";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return NeoUsuarioID;
        }


    }
}

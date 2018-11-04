﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class Global
    {
        private static bool _LoggedIN;
        private static Usuarios _Usuario;
        private static Empleados _Empleado;
        private static Cajas _Caja;
        public static bool LoggedIN
        {
            get { return _LoggedIN; }
            set { _LoggedIN = value; }
        }
        public static Usuarios Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        public static Empleados Empleado
        {
            get { return _Empleado; }
            set { _Empleado = value; }
        }
        public static Cajas Caja
        {
            get { return _Caja; }
            set { _Caja = value; }
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

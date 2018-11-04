using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsconPOS.classes
{
    class Empresas
    {
        public long EmpresaID { get; set; }
        public long IdentificacionID { get; set; }
        public string NroDocIdent { get; set; }
        public string NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public Nullable<long> DistritoID { get; set; }
        public string Urbanizacion { get; set; }
        public string NroTelefonico { get; set; }
        public string CorreoElectronico { get; set; }

        public virtual Distritos Distritos { get; set; }
        public virtual ICollection<Documentos> Documentos { get; set; }
        public virtual Identificaciones Identificaciones { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}

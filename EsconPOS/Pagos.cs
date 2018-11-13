//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EsconPOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagos
    {
        public long PagoID { get; set; }
        public long DocumentoID { get; set; }
        public long FormaPagoID { get; set; }
        public long MonedaID { get; set; }
        public double MontoPago { get; set; }
        public Nullable<long> BancoID { get; set; }
        public string NroDocPago { get; set; }
        public string Autorizacion { get; set; }
        public string AgregadoEl { get; set; }
        public long AgregadoPor { get; set; }
        public string ModificadoEl { get; set; }
        public Nullable<long> ModificadoPor { get; set; }
    
        public virtual Documentos Documentos { get; set; }
        public virtual Empleados EmpleadoAdd { get; set; }
        public virtual Empleados EmpleadoUpd { get; set; }
        public virtual FormasPagos FormasPagos { get; set; }
        public virtual Monedas Monedas { get; set; }
    }
}

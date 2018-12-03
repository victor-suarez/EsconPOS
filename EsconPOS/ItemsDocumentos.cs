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
    
    public partial class ItemsDocumentos
    {
        public long DocumentoID { get; set; }
        public long ItemID { get; set; }
        public long ProductoID { get; set; }
        public long Cantidad { get; set; }
        public long ImpuestoID { get; set; }
        public double TasaImpuesto { get; set; }
        public double MontoImpuesto { get; set; }
        public double MontoNeto { get; set; }
        public long EsDevolucion { get; set; }
        public Nullable<long> AutorizadoPor { get; set; }
        public string FechaHoraAutorizado { get; set; }
        public double MontoDescuento { get; set; }
        public Nullable<long> VendidoPor { get; set; }
        public double ValorUnitario { get; set; }
    
        public virtual Documentos Documentos { get; set; }
        public virtual Empleados EmpleadoAut { get; set; }
        public virtual Impuestos Impuestos { get; set; }
        public virtual Productos Productos { get; set; }
        public virtual Empleados EmpleadoVen { get; set; }
    }
}

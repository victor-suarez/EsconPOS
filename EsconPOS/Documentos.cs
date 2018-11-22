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
    
    public partial class Documentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documentos()
        {
            this.ItemsDocumentos = new HashSet<ItemsDocumentos>();
            this.Pagos = new HashSet<Pagos>();
        }
    
        public long DocumentoID { get; set; }
        public long NroDocumento { get; set; }
        public long TipoDocumentoID { get; set; }
        public string FechaDocumento { get; set; }
        public string HoraDocumento { get; set; }
        public long EmpresaID { get; set; }
        public long ClienteID { get; set; }
        public long EmpleadoID { get; set; }
        public long CajaID { get; set; }
        public long TotalProductos { get; set; }
        public double MontoBruto { get; set; }
        public double MontoGravado { get; set; }
        public double MontoImpuestos { get; set; }
        public double MontoExcento { get; set; }
        public double SubTotal { get; set; }
        public double MontoDescuentos { get; set; }
        public double MontoNeto { get; set; }
        public Nullable<long> RefDocumentoID { get; set; }
        public string AgregadoEl { get; set; }
        public long AgregadoPor { get; set; }
        public string ModificadoEl { get; set; }
        public Nullable<long> ModificadoPor { get; set; }
        public double MontoPagado { get; set; }
    
        public virtual Cajas Cajas { get; set; }
        public virtual Clientes Clientes { get; set; }
        public virtual TiposDocumentos TiposDocumentos { get; set; }
        public virtual Empleados Empleados { get; set; }
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsDocumentos> ItemsDocumentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }
    }
}

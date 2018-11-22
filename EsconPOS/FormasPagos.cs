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
    
    public partial class FormasPagos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormasPagos()
        {
            this.Pagos = new HashSet<Pagos>();
        }
    
        public long FormaPagoID { get; set; }
        public string FormaPago { get; set; }
        public string Codigo { get; set; }
        public long Orden { get; set; }
        public long RequiereAutorizacion { get; set; }
        public long Activo { get; set; }
        public string AgregadoEl { get; set; }
        public Nullable<long> AgregadoPor { get; set; }
        public string ModificadoEl { get; set; }
        public Nullable<long> ModificadoPor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }
        public virtual Empleados EmpleadoAdd { get; set; }
        public virtual Empleados EmpleadoUpd { get; set; }
    }
}

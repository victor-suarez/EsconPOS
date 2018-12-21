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
    
    public partial class Monedas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Monedas()
        {
            this.Pagos = new HashSet<Pagos>();
            this.Documentos = new HashSet<Documentos>();
        }
    
        public long MonedaID { get; set; }
        public string Codigo { get; set; }
        public string Moneda { get; set; }
        public long PorDefecto { get; set; }
        public double FactorCambiario { get; set; }
        public long Activo { get; set; }
        public string AgregadoEl { get; set; }
        public long AgregadoPor { get; set; }
    
        public virtual Empleados EmpleadoAdd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> Pagos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos> Documentos { get; set; }
    }
}

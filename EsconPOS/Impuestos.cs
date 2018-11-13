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
    
    public partial class Impuestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Impuestos()
        {
            this.ItemsDocumentos = new HashSet<ItemsDocumentos>();
            this.Productos = new HashSet<Productos>();
        }
    
        public long ImpuestoID { get; set; }
        public string Codigo { get; set; }
        public string Impuesto { get; set; }
        public string Tipo { get; set; }
        public byte[] Categoria { get; set; }
        public string Iniciales { get; set; }
        public double Tasa { get; set; }
        public string ValidoDesde { get; set; }
        public string ValidoHasta { get; set; }
        public long Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsDocumentos> ItemsDocumentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }
    }
}

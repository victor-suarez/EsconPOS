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
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.ItemsDocumentos = new HashSet<ItemsDocumentos>();
        }
    
        public long ProductoID { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string Producto { get; set; }
        public Nullable<long> TipoProductoID { get; set; }
        public Nullable<long> MarcaID { get; set; }
        public long ImpuestoID { get; set; }
        public long UnidadMedidaID { get; set; }
        public string Presentacion { get; set; }
        public long Activo { get; set; }
        public string AgregadoEl { get; set; }
        public long AgregadoPor { get; set; }
    
        public virtual Impuestos Impuestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsDocumentos> ItemsDocumentos { get; set; }
        public virtual Marcas Marcas { get; set; }
        public virtual UnidadesMedidas UnidadesMedidas { get; set; }
        public virtual TiposProductos TiposProductos { get; set; }
    }
}

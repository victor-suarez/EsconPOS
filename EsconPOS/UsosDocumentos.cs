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
    
    public partial class UsosDocumentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsosDocumentos()
        {
            this.TiposDocumentos = new HashSet<TiposDocumentos>();
        }
    
        public long UsoID { get; set; }
        public string Codigo { get; set; }
        public string Uso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiposDocumentos> TiposDocumentos { get; set; }
    }
}
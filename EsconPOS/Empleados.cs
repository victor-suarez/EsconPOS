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
    
    public partial class Empleados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleados()
        {
            this.CajaLog = new HashSet<CajaLog>();
            this.ClientesUpdated = new HashSet<Clientes>();
            this.ClientesAdded = new HashSet<Clientes>();
            this.Documentos = new HashSet<Documentos>();
            this.EmpresasUpdated = new HashSet<Empresas>();
            this.EmpresasAdded = new HashSet<Empresas>();
            this.ItemsDocumentos = new HashSet<ItemsDocumentos>();
            this.MarcasAdded = new HashSet<Marcas>();
            this.MarcasUpdated = new HashSet<Marcas>();
            this.Monedas = new HashSet<Monedas>();
            this.PagosAdded = new HashSet<Pagos>();
            this.PagosUpdated = new HashSet<Pagos>();
            this.ProductosUpdated = new HashSet<Productos>();
            this.ProductosAdded = new HashSet<Productos>();
            this.TiposProductosUpdated = new HashSet<TiposProductos>();
            this.TiposProductosAdded = new HashSet<TiposProductos>();
            this.Empresas = new HashSet<Empresas>();
            this.EmpleadosAdded = new HashSet<Empleados>();
            this.EmpleadosUpdated = new HashSet<Empleados>();
        }
    
        public long EmpleadoID { get; set; }
        public long IdentificacionID { get; set; }
        public string NroDocIdent { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Login { get; set; }
        public string PasswdHash { get; set; }
        public long EsSupervisor { get; set; }
        public long EsAdministrador { get; set; }
        public Nullable<long> Activo { get; set; }
        public string AgregadoEl { get; set; }
        public Nullable<long> AgregadoPor { get; set; }
        public string ModificadoEl { get; set; }
        public Nullable<long> ModificadoPor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CajaLog> CajaLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> ClientesUpdated { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> ClientesAdded { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos> Documentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresas> EmpresasUpdated { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresas> EmpresasAdded { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsDocumentos> ItemsDocumentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marcas> MarcasAdded { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marcas> MarcasUpdated { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Monedas> Monedas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> PagosAdded { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pagos> PagosUpdated { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> ProductosUpdated { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> ProductosAdded { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiposProductos> TiposProductosUpdated { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TiposProductos> TiposProductosAdded { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresas> Empresas { get; set; }
        public virtual Identificaciones Identificaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> EmpleadosAdded { get; set; }
        public virtual Empleados EmpleadoAdd { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> EmpleadosUpdated { get; set; }
        public virtual Empleados EmpleadoUpd { get; set; }
    }
}

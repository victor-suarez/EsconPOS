﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mainEntities : DbContext
    {
        public mainEntities()
            : base("name=mainEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CajaLog> CajaLog { get; set; }
        public virtual DbSet<Cajas> Cajas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Configuraciones> Configuraciones { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<Distritos> Distritos { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<FormasPagos> FormasPagos { get; set; }
        public virtual DbSet<Identificaciones> Identificaciones { get; set; }
        public virtual DbSet<Impuestos> Impuestos { get; set; }
        public virtual DbSet<ItemsDocumentos> ItemsDocumentos { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<TiposDocumentos> TiposDocumentos { get; set; }
        public virtual DbSet<TiposProductos> TiposProductos { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<UnidadesMedidas> UnidadesMedidas { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login.CDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbAudioCorrientesEntities : DbContext
    {
        public dbAudioCorrientesEntities()
            : base("name=dbAudioCorrientesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<TipoCliente> TipoClientes { get; set; }
        public virtual DbSet<TipoFactura> TipoFacturas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
    }
}

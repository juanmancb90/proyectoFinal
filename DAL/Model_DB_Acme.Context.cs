﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_AcmeEntities1 : DbContext
    {
        public DB_AcmeEntities1()
            : base("name=DB_AcmeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TB_Categoria> TB_Categoria { get; set; }
        public DbSet<TB_Ciudad> TB_Ciudad { get; set; }
        public DbSet<TB_Cliente> TB_Cliente { get; set; }
        public DbSet<TB_DetallePedido> TB_DetallePedido { get; set; }
        public DbSet<TB_Documento> TB_Documento { get; set; }
        public DbSet<TB_Pedido> TB_Pedido { get; set; }
        public DbSet<TB_Producto> TB_Producto { get; set; }
        public DbSet<TB_Promocion> TB_Promocion { get; set; }
        public DbSet<TB_Vendedor> TB_Vendedor { get; set; }
    }
}

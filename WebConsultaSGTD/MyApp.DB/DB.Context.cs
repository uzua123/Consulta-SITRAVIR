﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBSTDEntities : DbContext
    {
        public DBSTDEntities()
            : base("name=DBSTDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_CARGO> TBL_CARGO { get; set; }
        public virtual DbSet<TBL_CORRELATIVO_EXPEDIENTE> TBL_CORRELATIVO_EXPEDIENTE { get; set; }
        public virtual DbSet<TBL_DET_EXPEDIENTE> TBL_DET_EXPEDIENTE { get; set; }
        public virtual DbSet<TBL_EMPLEADO> TBL_EMPLEADO { get; set; }
        public virtual DbSet<TBL_EMPRESA> TBL_EMPRESA { get; set; }
        public virtual DbSet<TBL_EXPEDIENTE> TBL_EXPEDIENTE { get; set; }
        public virtual DbSet<TBL_OFICINA> TBL_OFICINA { get; set; }
        public virtual DbSet<TBL_PERFIL> TBL_PERFIL { get; set; }
        public virtual DbSet<TBL_PERMISOS> TBL_PERMISOS { get; set; }
        public virtual DbSet<TBL_PERSONA> TBL_PERSONA { get; set; }
        public virtual DbSet<TBL_REQUISITO> TBL_REQUISITO { get; set; }
        public virtual DbSet<TBL_SOLICITANTE> TBL_SOLICITANTE { get; set; }
        public virtual DbSet<TBL_TIPO_DOCUMENTO> TBL_TIPO_DOCUMENTO { get; set; }
        public virtual DbSet<TBL_TUPA> TBL_TUPA { get; set; }
        public virtual DbSet<TBL_TUPA_REQUISITO> TBL_TUPA_REQUISITO { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProAdmin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntity : DbContext
    {
        public DBEntity()
            : base("name=DBEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<basicdata_batch> basicdata_batch { get; set; }
        public virtual DbSet<basicdata_university> basicdata_university { get; set; }
        public virtual DbSet<basicdata_school> basicdata_school { get; set; }
    }
}

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
    
    public partial class proadmin_v1Entities : DbContext
    {
        public proadmin_v1Entities()
            : base("name=proadmin_v1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<basicdata_batch> basicdata_batch { get; set; }
        public virtual DbSet<basicdata_school> basicdata_school { get; set; }
        public virtual DbSet<basicdata_student> basicdata_student { get; set; }
        public virtual DbSet<basicdata_subject> basicdata_subject { get; set; }
        public virtual DbSet<basicdata_university> basicdata_university { get; set; }
        public virtual DbSet<basicdata_users> basicdata_users { get; set; }
        public virtual DbSet<basicdate_schedule> basicdate_schedule { get; set; }
        public virtual DbSet<data_examresults> data_examresults { get; set; }
        public virtual DbSet<view_exam_results_summary> view_exam_results_summary { get; set; }
        public virtual DbSet<basicdata_class> basicdata_class { get; set; }
        public virtual DbSet<data_attandance> data_attandance { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcunMedyaAkademiProtfolio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbDominicPortfolioEntities : DbContext
    {
        public DbDominicPortfolioEntities()
            : base("name=DbDominicPortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_Project> Tbl_Project { get; set; }
        public virtual DbSet<Tbl_About> Tbl_About { get; set; }
        public virtual DbSet<Tbl_Feature> Tbl_Feature { get; set; }
        public virtual DbSet<Tbl_Service> Tbl_Service { get; set; }
        public virtual DbSet<Tbl_Testimonial> Tbl_Testimonial { get; set; }
        public virtual DbSet<Tbl_Contact> Tbl_Contact { get; set; }
    }
}

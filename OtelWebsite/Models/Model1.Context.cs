//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelWebsite.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OtelEntities3 : DbContext
    {
        public OtelEntities3()
            : base("name=OtelEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<MusteriHesap> MusteriHesaps { get; set; }
        public virtual DbSet<MusteriKayit> MusteriKayits { get; set; }
        public virtual DbSet<Odalar> Odalars { get; set; }
        public virtual DbSet<Servisler> Servislers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}

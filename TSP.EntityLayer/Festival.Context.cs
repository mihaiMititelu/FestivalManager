﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSP.EntityLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FestivalContainer : DbContext
    {
        public FestivalContainer()
            : base("name=FestivalContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Festival> Festivals { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Performer> Performers { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}
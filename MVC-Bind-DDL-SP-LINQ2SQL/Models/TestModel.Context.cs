﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Bind_DDL_SP_LINQ2SQL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BikeStoresEntities : DbContext
    {
        public BikeStoresEntities()
            : base("name=BikeStoresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
    
        public virtual ObjectResult<string> Get_Bike_Categories()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Get_Bike_Categories");
        }
    }
}

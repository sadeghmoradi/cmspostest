using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Brands;
using Entity.Model.Citys;
using Entity.Model.Customers;
using Entity.Model.CustomerTypes;
using Entity.Model.FactorDocDetails;
using Entity.Model.FactorDocs;
using Entity.Model.Goods;
using Entity.Model.Locations;
using Entity.Model.LocationTypes;
using Entity.Model.OwnerIdentitys;
using Entity.Model.Units;
using Entity.Model.UnitTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace EntityDB
{
    public class RepositoryContext : DbContext
    {
        //public RepositoryContext()
        //{

        //}
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {
            
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var converter = new EnumToStringConverter<LocationType>();
        //    modelBuilder
        //        .Entity<Location>()
        //        .Property(e => e.LocationType)
        //        .HasConversion(converter).IsUnicode(false).HasDefaultValue(LocationType.shop);
        //}
        public DbSet<Good> Goods { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<OwnerIdentity> OwnerIdentities { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<LocationType> LocationTypes { get; set; }
        public DbSet<FactorDoc> FactorDocs { get; set; }
        public DbSet<FactorDocDetail> FactorDocDetails { get; set; }
    }
}

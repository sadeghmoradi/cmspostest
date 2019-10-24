using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity.Model.Citys;
using Entity.Model.FactorDocDetails;
using Entity.Model.FactorDocs;
using Entity.Model.Goods;
using Entity.Model.Locations;
using Entity.Model.LocationTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace EntityDB
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext()
        {

        }
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
        public DbSet<FactorDoc> FactorDocs { get; set; }
        public DbSet<FactorDocDetail> FactorDocDetails { get; set; }
        public DbSet<Location> locations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<LocationType> LocationTypes { get; set; }
    }
}

﻿// <auto-generated />
using System;
using EntityDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cms.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Model.Brands.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Entity.Model.Citys.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerId");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Entity.Model.CustomerTypes.CustomerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CustomerTypes");
                });

            modelBuilder.Entity("Entity.Model.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Code");

                    b.Property<int?>("CustomerTypesId");

                    b.Property<string>("Email");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<string>("ShenaseMeli");

                    b.Property<string>("TellHome");

                    b.HasKey("Id");

                    b.HasIndex("CustomerTypesId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Entity.Model.FactorDocDetails.FactorDocDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressBuy");

                    b.Property<int?>("FactorDocsId");

                    b.Property<int?>("GoodsId");

                    b.Property<float>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("FactorDocsId");

                    b.HasIndex("GoodsId");

                    b.ToTable("FactorDocDetails");
                });

            modelBuilder.Entity("Entity.Model.FactorDocs.FactorDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("Confrimdate");

                    b.Property<string>("Date");

                    b.Property<int?>("LocationsId");

                    b.HasKey("Id");

                    b.HasIndex("LocationsId");

                    b.ToTable("FactorDocs");
                });

            modelBuilder.Entity("Entity.Model.Goods.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandsId");

                    b.Property<string>("Code");

                    b.Property<bool>("HasVat");

                    b.Property<string>("Name");

                    b.Property<int>("PackQty");

                    b.Property<int?>("UnitsId");

                    b.Property<bool>("HasToll");

                    b.HasKey("Id");

                    b.HasIndex("BrandsId");

                    b.HasIndex("UnitsId");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("Entity.Model.LocationTypes.LocationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("LocationTypes");
                });

            modelBuilder.Entity("Entity.Model.Locations.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int?>("CitiesId");

                    b.Property<string>("Code");

                    b.Property<int?>("LocationTypesId");

                    b.Property<string>("Name");

                    b.Property<string>("Tell");

                    b.HasKey("Id");

                    b.HasIndex("CitiesId");

                    b.HasIndex("LocationTypesId");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("Entity.Model.OwnerIdentitys.OwnerIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OwnerIdentities");
                });

            modelBuilder.Entity("Entity.Model.UnitTypes.UnitType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("UnitTypes");
                });

            modelBuilder.Entity("Entity.Model.Units.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<int?>("UnitTypesId");

                    b.HasKey("Id");

                    b.HasIndex("UnitTypesId");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Entity.Model.Customers.Customer", b =>
                {
                    b.HasOne("Entity.Model.CustomerTypes.CustomerType", "CustomerTypes")
                        .WithMany()
                        .HasForeignKey("CustomerTypesId");
                });

            modelBuilder.Entity("Entity.Model.FactorDocDetails.FactorDocDetail", b =>
                {
                    b.HasOne("Entity.Model.FactorDocs.FactorDoc", "FactorDocs")
                        .WithMany()
                        .HasForeignKey("FactorDocsId");

                    b.HasOne("Entity.Model.Goods.Good", "Goods")
                        .WithMany()
                        .HasForeignKey("GoodsId");
                });

            modelBuilder.Entity("Entity.Model.FactorDocs.FactorDoc", b =>
                {
                    b.HasOne("Entity.Model.Locations.Location", "Locations")
                        .WithMany()
                        .HasForeignKey("LocationsId");
                });

            modelBuilder.Entity("Entity.Model.Goods.Good", b =>
                {
                    b.HasOne("Entity.Model.Brands.Brand", "Brands")
                        .WithMany()
                        .HasForeignKey("BrandsId");

                    b.HasOne("Entity.Model.Units.Unit", "Units")
                        .WithMany()
                        .HasForeignKey("UnitsId");
                });

            modelBuilder.Entity("Entity.Model.Locations.Location", b =>
                {
                    b.HasOne("Entity.Model.Citys.City", "Cities")
                        .WithMany()
                        .HasForeignKey("CitiesId");

                    b.HasOne("Entity.Model.LocationTypes.LocationType", "LocationTypes")
                        .WithMany()
                        .HasForeignKey("LocationTypesId");
                });

            modelBuilder.Entity("Entity.Model.Units.Unit", b =>
                {
                    b.HasOne("Entity.Model.UnitTypes.UnitType", "UnitTypes")
                        .WithMany()
                        .HasForeignKey("UnitTypesId");
                });
#pragma warning restore 612, 618
        }
    }
}

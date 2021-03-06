﻿// <auto-generated />
using System;
using EntityDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cms.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20190616140322_Create database")]
    partial class Createdatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Base.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Model.Base.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("Model.Base.Location", b =>
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

            modelBuilder.Entity("Model.Base.LocationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("LocationTypes");
                });

            modelBuilder.Entity("Model.sal.FactorDoc", b =>
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

            modelBuilder.Entity("Model.sal.FactorDocDetail", b =>
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

            modelBuilder.Entity("Model.Base.Location", b =>
                {
                    b.HasOne("Model.Base.City", "Cities")
                        .WithMany("LocatioId")
                        .HasForeignKey("CitiesId");

                    b.HasOne("Model.Base.LocationType", "LocationTypes")
                        .WithMany("LocationTypeId")
                        .HasForeignKey("LocationTypesId");
                });

            modelBuilder.Entity("Model.sal.FactorDoc", b =>
                {
                    b.HasOne("Model.Base.Location", "Locations")
                        .WithMany("LocationId")
                        .HasForeignKey("LocationsId");
                });

            modelBuilder.Entity("Model.sal.FactorDocDetail", b =>
                {
                    b.HasOne("Model.sal.FactorDoc", "FactorDocs")
                        .WithMany("FactorDocId")
                        .HasForeignKey("FactorDocsId");

                    b.HasOne("Model.Base.Good", "Goods")
                        .WithMany("GoodId")
                        .HasForeignKey("GoodsId");
                });
#pragma warning restore 612, 618
        }
    }
}

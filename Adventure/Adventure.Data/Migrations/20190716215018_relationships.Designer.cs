﻿// <auto-generated />
using System;
using Adventure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adventure.Data.Migrations
{
    [DbContext(typeof(AdventureDbContext))]
    [Migration("20190716215018_relationships")]
    partial class relationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Adventure.Domain.Entities.Coordinator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CellPhone");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Coordinators");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CoordinatorId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FromDate");

                    b.Property<Guid?>("LocationId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<Guid?>("PriceId");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatorId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PriceId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.EventImage", b =>
                {
                    b.Property<Guid>("EventId");

                    b.Property<Guid>("ImageId");

                    b.HasKey("EventId", "ImageId");

                    b.HasIndex("ImageId");

                    b.ToTable("EventImage");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.GeoCoordinate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("GeoCoordinates");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Base64");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<Guid?>("GpsLocationId");

                    b.Property<string>("Province");

                    b.Property<string>("Surburb");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.HasIndex("GpsLocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.Price", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AdultsPrice");

                    b.Property<decimal>("KidsPrice");

                    b.Property<decimal>("SeniorCitizenPrice");

                    b.HasKey("Id");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.Event", b =>
                {
                    b.HasOne("Adventure.Domain.Entities.Coordinator", "Coordinator")
                        .WithMany()
                        .HasForeignKey("CoordinatorId");

                    b.HasOne("Adventure.Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("Adventure.Domain.Entities.Price", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId");
                });

            modelBuilder.Entity("Adventure.Domain.Entities.EventImage", b =>
                {
                    b.HasOne("Adventure.Domain.Entities.Event", "Event")
                        .WithMany("EventImages")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Adventure.Domain.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Adventure.Domain.Entities.Location", b =>
                {
                    b.HasOne("Adventure.Domain.Entities.GeoCoordinate", "GpsLocation")
                        .WithMany()
                        .HasForeignKey("GpsLocationId");
                });
#pragma warning restore 612, 618
        }
    }
}

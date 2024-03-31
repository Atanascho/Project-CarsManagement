﻿// <auto-generated />
using System;
using CarsManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarsManagement.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240330125707_InitialExtended")]
    partial class InitialExtended
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarsManagement.Data.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<int?>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ManufacturerID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarsManagement.Data.Models.Manufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("CarsManagement.Data.Models.ManufacturerCars", b =>
                {
                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int");

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.HasKey("ManufacturerID", "CarID");

                    b.HasIndex("CarID");

                    b.ToTable("ManufacturerCars");
                });

            modelBuilder.Entity("CarsManagement.Data.Models.Car", b =>
                {
                    b.HasOne("CarsManagement.Data.Models.Manufacturer", null)
                        .WithMany("Cars")
                        .HasForeignKey("ManufacturerID");
                });

            modelBuilder.Entity("CarsManagement.Data.Models.ManufacturerCars", b =>
                {
                    b.HasOne("CarsManagement.Data.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarsManagement.Data.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("ManufacturerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("CarsManagement.Data.Models.Manufacturer", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
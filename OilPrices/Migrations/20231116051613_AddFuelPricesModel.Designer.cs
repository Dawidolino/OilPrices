﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OilPrices.Models;

#nullable disable

namespace OilPrices.Migrations
{
    [DbContext(typeof(OilPricesAppContext))]
    [Migration("20231116051613_AddFuelPricesModel")]
    partial class AddFuelPricesModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OilPrices.Models.FuelPrices", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<short>("FuelStationId")
                        .HasColumnType("smallint");

                    b.Property<string>("LPG")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ON")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("PriceEditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RON95")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RON98")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("FuelStationId");

                    b.ToTable("FuelPrices");
                });

            modelBuilder.Entity("OilPrices.Models.FuelStation", b =>
                {
                    b.Property<short>("Id")
                        .HasColumnType("smallint")
                        .HasColumnName("ID");

                    b.Property<string>("Adres")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ADRES");

                    b.Property<string>("KodPocztowy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("KOD_POCZTOWY");

                    b.Property<string>("Lpg")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("LPG");

                    b.Property<string>("Miejscowosc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MIEJSCOWOSC");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("NAZWA");

                    b.Property<string>("On")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("ON");

                    b.Property<string>("Powiat")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("POWIAT");

                    b.Property<string>("Ron95")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("RON95");

                    b.Property<string>("Ron98")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("RON98");

                    b.Property<string>("Wojewodztwo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("WOJEWODZTWO");

                    b.HasKey("Id");

                    b.ToTable("FuelStations");
                });

            modelBuilder.Entity("OilPrices.Models.FuelPrices", b =>
                {
                    b.HasOne("OilPrices.Models.FuelStation", "FuelStation")
                        .WithMany()
                        .HasForeignKey("FuelStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FuelStation");
                });
#pragma warning restore 612, 618
        }
    }
}
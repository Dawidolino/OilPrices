using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OilPrices.Models;

public partial class OilPricesAppContext : DbContext
{
    public OilPricesAppContext()
    {
    }

    public OilPricesAppContext(DbContextOptions<OilPricesAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FuelStation> FuelStations { get; set; }
    //public DbSet<FuelPrices> FuelPrices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-ID0J670;Database=OilPricesApp;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FuelStation>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(100)
                .HasColumnName("ADRES");
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(50)
                .HasColumnName("KOD_POCZTOWY");
            entity.Property(e => e.Lpg)
                .HasMaxLength(10)
                .HasColumnName("LPG");
            entity.Property(e => e.Miejscowosc)
                .HasMaxLength(50)
                .HasColumnName("MIEJSCOWOSC");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(200)
                .HasColumnName("NAZWA");
            entity.Property(e => e.On)
                .HasMaxLength(10)
                .HasColumnName("ON");
            entity.Property(e => e.Powiat)
                .HasMaxLength(50)
                .HasColumnName("POWIAT");
            entity.Property(e => e.Ron95)
                .HasMaxLength(10)
                .HasColumnName("RON95");
            entity.Property(e => e.Ron98)
                .HasMaxLength(10)
                .HasColumnName("RON98");
            entity.Property(e => e.Wojewodztwo)
                .HasMaxLength(50)
                .HasColumnName("WOJEWODZTWO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

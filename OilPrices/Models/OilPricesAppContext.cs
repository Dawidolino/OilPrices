using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OilPrices.Models;

public partial class OilPricesAppContext : DbContext
{
    

    public OilPricesAppContext(DbContextOptions<OilPricesAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FuelStation> FuelStations { get; set; }    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
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

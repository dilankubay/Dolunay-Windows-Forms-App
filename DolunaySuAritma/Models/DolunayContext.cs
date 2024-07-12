using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DolunaySuAritma.Models;

public partial class DolunayContext : DbContext
{
    public DolunayContext()
    {
    }

    public DolunayContext(DbContextOptions<DolunayContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BakimFormlari> BakimFormlaris { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DILANKUBAY\\SQLEXPRESS;Database=Dolunay;User Id=sa;Password=D12ilan45;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BakimFormlari>(entity =>
        {
            entity.ToTable("BakimFormlari");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdSoyad).HasColumnName("adSoyad");
            entity.Property(e => e.Adres).HasColumnName("adres");
            entity.Property(e => e.BesCesmeDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("besCesmeDegisimTarihi");
            entity.Property(e => e.BesCesmeDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("besCesmeDegisimUcreti");
            entity.Property(e => e.BesFiltreDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("besFiltreDegisimTarihi");
            entity.Property(e => e.BesFiltreDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("besFiltreDegisimUcreti");
            entity.Property(e => e.BesMembranDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("besMembranDegisimTarihi");
            entity.Property(e => e.BesMembranDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("besMembranDegisimUcreti");
            entity.Property(e => e.BesTankDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("besTankDegisimTarihi");
            entity.Property(e => e.BesTankDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("besTankDegisimUcreti");
            entity.Property(e => e.BesTatDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("besTatDegisimTarihi");
            entity.Property(e => e.BesTatDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("besTatDegisimUcreti");
            entity.Property(e => e.BirCesmeDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("birCesmeDegisimTarihi");
            entity.Property(e => e.BirCesmeDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("birCesmeDegisimUcreti");
            entity.Property(e => e.BirFiltreDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("birFiltreDegisimTarihi");
            entity.Property(e => e.BirFiltreDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("birFiltreDegisimUcreti");
            entity.Property(e => e.BirMembranDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("birMembranDegisimTarihi");
            entity.Property(e => e.BirMembranDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("birMembranDegisimUcreti");
            entity.Property(e => e.BirTankDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("birTankDegisimTarihi");
            entity.Property(e => e.BirTankDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("birTankDegisimUcreti");
            entity.Property(e => e.BirTatDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("birTatDegisimTarihi");
            entity.Property(e => e.BirTatDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("birTatDegisimUcreti");
            entity.Property(e => e.DortCesmeDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("dortCesmeDegisimTarihi");
            entity.Property(e => e.DortCesmeDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("dortCesmeDegisimUcreti");
            entity.Property(e => e.DortFiltreDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("dortFiltreDegisimTarihi");
            entity.Property(e => e.DortFiltreDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("dortFiltreDegisimUcreti");
            entity.Property(e => e.DortMembranDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("dortMembranDegisimTarihi");
            entity.Property(e => e.DortMembranDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("dortMembranDegisimUcreti");
            entity.Property(e => e.DortTankDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("dortTankDegisimTarihi");
            entity.Property(e => e.DortTankDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("dortTankDegisimUcreti");
            entity.Property(e => e.DortTatDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("dortTatDegisimTarihi");
            entity.Property(e => e.DortTatDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("dortTatDegisimUcreti");
            entity.Property(e => e.IkiCesmeDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ikiCesmeDegisimTarihi");
            entity.Property(e => e.IkiCesmeDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ikiCesmeDegisimUcreti");
            entity.Property(e => e.IkiFiltreDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ikiFiltreDegisimTarihi");
            entity.Property(e => e.IkiFiltreDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ikiFiltreDegisimUcreti");
            entity.Property(e => e.IkiMembranDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ikiMembranDegisimTarihi");
            entity.Property(e => e.IkiMembranDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ikiMembranDegisimUcreti");
            entity.Property(e => e.IkiTankDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ikiTankDegisimTarihi");
            entity.Property(e => e.IkiTankDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ikiTankDegisimUcreti");
            entity.Property(e => e.IkiTatDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ikiTatDegisimTarihi");
            entity.Property(e => e.IkiTatDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ikiTatDegisimUcreti");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ilce");
            entity.Property(e => e.Mahalle)
                .HasMaxLength(50)
                .HasColumnName("mahalle");
            entity.Property(e => e.Sehir)
                .HasMaxLength(50)
                .HasColumnName("sehir");
            entity.Property(e => e.TelNo)
                .HasMaxLength(15)
                .HasColumnName("telNo");
            entity.Property(e => e.UcCesmeDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ucCesmeDegisimTarihi");
            entity.Property(e => e.UcCesmeDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ucCesmeDegisimUcreti");
            entity.Property(e => e.UcFiltreDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ucFiltreDegisimTarihi");
            entity.Property(e => e.UcFiltreDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ucFiltreDegisimUcreti");
            entity.Property(e => e.UcMembranDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ucMembranDegisimTarihi");
            entity.Property(e => e.UcMembranDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ucMembranDegisimUcreti");
            entity.Property(e => e.UcTankDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ucTankDegisimTarihi");
            entity.Property(e => e.UcTankDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ucTankDegisimUcreti");
            entity.Property(e => e.UcTatDegisimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ucTatDegisimTarihi");
            entity.Property(e => e.UcTatDegisimUcreti)
                .HasMaxLength(10)
                .HasColumnName("ucTatDegisimUcreti");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

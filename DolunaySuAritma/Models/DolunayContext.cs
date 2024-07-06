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
        => optionsBuilder.UseSqlServer("Server=DILANKUBAY\\SQLEXPRESS;Database=Dolunay;Integrated Security=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BakimFormlari>(entity =>
        {
            entity.ToTable("BakimFormlari");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .HasColumnName("ad");
            entity.Property(e => e.Adres).HasColumnName("adres");
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .HasColumnName("soyad");
            entity.Property(e => e.TelNo)
                .HasMaxLength(15)
                .HasColumnName("telNo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

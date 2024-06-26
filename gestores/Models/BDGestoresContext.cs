using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace gestores.Models
{
    public partial class BDGestoresContext : DbContext
    {
        public BDGestoresContext()
        {
        }

        public BDGestoresContext(DbContextOptions<BDGestoresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblGestorSaldoDetalle> TblGestorSaldoDetalle { get; set; }
        public virtual DbSet<TblGestore> TblGestore { get; set; }
        public virtual DbSet<TblSaldo> TblSaldo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-JTTRPKK;Database=BDGestores;User ID=SA;Password=1234;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblGestorSaldoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdGestorSaldoDetalle)
                    .HasName("pk_IdGestorSaldoDetalle_tblGestorSaldoDetalle");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.TblGestorSaldoDetalle)
                    .HasForeignKey(d => d.IdGestor)
                    .HasConstraintName("fk_IdGestor_tblGestorSaldoDetalle");

                entity.HasOne(d => d.IdSaldoNavigation)
                    .WithMany(p => p.TblGestorSaldoDetalle)
                    .HasForeignKey(d => d.IdSaldo)
                    .HasConstraintName("fk_IdSaldo_tblGestorSaldoDetalle");
            });

            modelBuilder.Entity<TblGestore>(entity =>
            {
                entity.HasKey(e => e.IdGestor)
                    .HasName("pk_IdGestor_tblGestore");

                entity.HasIndex(e => e.IdGestor)
                    .HasName("ix_tblGestore_IdGestor");
            });

            modelBuilder.Entity<TblSaldo>(entity =>
            {
                entity.HasKey(e => e.IdSaldo)
                    .HasName("pk_IdSaldo_tblSaldo");

                entity.HasIndex(e => e.IdSaldo)
                    .HasName("ix_tblSaldo_IdSaldo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

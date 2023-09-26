using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class computadorasBDContext : DbContext
    {
        public computadorasBDContext()
        {
        }

        public computadorasBDContext(DbContextOptions<computadorasBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Computer> Computers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QGC4GNA\\SQLEXPRESS;Database=computadorasBD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>(entity =>
            {
                entity.ToTable("computers");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand");

                entity.Property(e => e.Model)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Size)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("size");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

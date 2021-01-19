using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoffeeAdmin.Models
{
    public partial class CoffeeContext : IdentityDbContext
    {
        public CoffeeContext()
        {
        }

        public CoffeeContext(DbContextOptions<CoffeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coffee> Coffee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coffee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AsalKopi)
                    .HasColumnName("Asal_Kopi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeskripsiKopi)
                    .HasColumnName("Deskripsi_Kopi")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JenisKopi)
                    .HasColumnName("Jenis_Kopi")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamaKopi)
                    .HasColumnName("Nama_Kopi")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}

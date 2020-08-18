using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApiExample.Persistence.Models
{
    public partial class WebApiExampleDbContext : DbContext
    {
        public WebApiExampleDbContext()
        {
        }

        public WebApiExampleDbContext(DbContextOptions<WebApiExampleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbEmployees> TbEmployees { get; set; }
        public virtual DbSet<TbSectors> TbSectors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                                optionsBuilder.UseSqlServer("Server=(local)\\MSSQLSERVER2017;Database=WebApiExample; Trusted_Connection=True;");*/
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbEmployees>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__tbEmploy__51C8DD7A18550D21");

                entity.ToTable("tbEmployees");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NameFull)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Thumbnail)
                    .HasColumnName("thumbnail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSectorNavigation)
                    .WithMany(p => p.TbEmployees)
                    .HasForeignKey(d => d.IdSector)
                    .HasConstraintName("FK__tbEmploye__IdSec__398D8EEE");
            });

            modelBuilder.Entity<TbSectors>(entity =>
            {
                entity.HasKey(e => e.IdSector)
                    .HasName("PK__tbSector__D0011C18EAD3B922");

                entity.ToTable("tbSectors");

                entity.Property(e => e.NameSector)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

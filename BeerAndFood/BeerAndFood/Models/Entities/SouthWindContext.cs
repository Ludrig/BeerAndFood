using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeerAndFood.Models.Entities
{
    public partial class SouthWindContext : DbContext
    {
        public virtual DbSet<Beer> Beer { get; set; }
        public virtual DbSet<BeerAndFood> BeerAndFood { get; set; }
        public virtual DbSet<Food> Food { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SouthWind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>(entity =>
            {
                entity.Property(e => e.Beername)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sort)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BeerAndFood>(entity =>
            {
                entity.HasOne(d => d.IdBeerNavigation)
                    .WithMany(p => p.BeerAndFood)
                    .HasForeignKey(d => d.IdBeer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BeerAndFo__IdBee__34C8D9D1");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.BeerAndFood)
                    .HasForeignKey(d => d.IdFood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BeerAndFo__IdFoo__35BCFE0A");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.Property(e => e.Food1)
                    .IsRequired()
                    .HasColumnName("Food")
                    .HasColumnType("nchar(50)");
            });
        }
    }
}

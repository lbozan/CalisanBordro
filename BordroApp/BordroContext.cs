using BordroApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BordroApp
{
    public class BordroContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string cnnStr = @"Server=.;Database=BordroDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(cnnStr);
        }

        public DbSet<Calisan> Calisan { get; set; }
        public DbSet<MaasTipi> MaasTipi { get; set; }
        public DbSet<ZamanTipi> ZamanTipi { get; set; }
        public DbSet<CalisanMaasRelations> CalisanMaasRelations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Calisan>(c =>
            {
                c.Property(v => v.Ad).HasMaxLength(50);
                c.Property(v => v.Soyad).HasMaxLength(50);
                c.Property(v => v.TC).HasMaxLength(11);

                c.ToTable("Calisan");
            });

            modelBuilder.Entity<MaasTipi>(c =>
            {
                c.Property(v => v.Ucret).HasColumnType("decimal(18, 2)");
                c.Property(v => v.Tip).HasMaxLength(30);
            });
        }
    }
}

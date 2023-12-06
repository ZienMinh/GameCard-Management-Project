using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Repositories.Models
{
    public partial class GameCard2023DBContext : DbContext
    {
        public GameCard2023DBContext()
        {
        }

        public GameCard2023DBContext(DbContextOptions<GameCard2023DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GameCardInfo> GameCardInfos { get; set; } = null!;
        public virtual DbSet<MemberAccount> MemberAccounts { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer(GetConnectionString());
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];

            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameCardInfo>(entity =>
            {
                entity.HasKey(e => e.GameCardId)
                    .HasName("PK__GameCard__903C838CB0038584");

                entity.ToTable("GameCardInfo");

                entity.Property(e => e.GameCardId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GameCardName).HasMaxLength(90);

                entity.Property(e => e.GameDescription).HasMaxLength(250);

                entity.Property(e => e.GamePlatform).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProviderId).HasMaxLength(30);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.GameCardInfos)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__GameCardI__Provi__3C69FB99");
            });

            modelBuilder.Entity<MemberAccount>(entity =>
            {
                entity.ToTable("MemberAccount");

                entity.HasIndex(e => e.MemberEmail, "UQ__MemberAc__3F37B77A583DFB1F")
                    .IsUnique();

                entity.Property(e => e.MemberAccountId)
                    .ValueGeneratedNever()
                    .HasColumnName("MemberAccountID");

                entity.Property(e => e.MemberAccountPassword).HasMaxLength(60);

                entity.Property(e => e.MemberEmail).HasMaxLength(100);

                entity.Property(e => e.MemberFullName).HasMaxLength(100);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider");

                entity.Property(e => e.ProviderId).HasMaxLength(30);

                entity.Property(e => e.ProviderDescription).HasMaxLength(250);

                entity.Property(e => e.ProviderName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

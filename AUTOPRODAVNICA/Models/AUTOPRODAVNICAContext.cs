using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AUTOPRODAVNICA.Models
{
    public partial class AUTOPRODAVNICAContext : DbContext
    {
        public AUTOPRODAVNICAContext()
        {
        }

        public AUTOPRODAVNICAContext(DbContextOptions<AUTOPRODAVNICAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Automobil> Automobil { get; set; }
        public virtual DbSet<Cenovnik> Cenovnik { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Musterija> Musterija { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
        public virtual DbSet<Radnja> Radnja { get; set; }
        public virtual DbSet<Radnjaautomobil> Radnjaautomobil { get; set; }
        public virtual DbSet<Radnomjesto> Radnomjesto { get; set; }
        public virtual DbSet<Servis> Servis { get; set; }
        public virtual DbSet<Servismusterija> Servismusterija { get; set; }
        public virtual DbSet<Stavka> Stavka { get; set; }
        public virtual DbSet<Zaposleni> Zaposleni { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AutoProdavnicaConnectionString"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automobil>(entity =>
            {
                entity.HasKey(e => e.ChasisNum)
                    .HasName("AUTOMOBIL_PK");

                entity.ToTable("AUTOMOBIL");

                entity.Property(e => e.ChasisNum).HasColumnName("CHASIS_NUM");

                entity.Property(e => e.Cenovnik).HasColumnName("CENOVNIK");

                entity.Property(e => e.Marka).HasColumnName("MARKA");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("MODEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.YearP).HasColumnName("YEAR_P");

                entity.HasOne(d => d.CenovnikNavigation)
                    .WithMany(p => p.Automobil)
                    .HasForeignKey(d => d.Cenovnik)
                    .HasConstraintName("CENOVNIK_FK");

                entity.HasOne(d => d.MarkaNavigation)
                    .WithMany(p => p.Automobil)
                    .HasForeignKey(d => d.Marka)
                    .HasConstraintName("MARKA_FK");
            });

            modelBuilder.Entity<Cenovnik>(entity =>
            {
                entity.ToTable("CENOVNIK");

                entity.Property(e => e.CenovnikId).HasColumnName("CENOVNIK_ID");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("DATE_END")
                    .HasColumnType("date");

                entity.Property(e => e.DateStart)
                    .HasColumnName("DATE_START")
                    .HasColumnType("date");

               
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("MARKA_PK");

                entity.ToTable("MARKA");

                entity.HasIndex(e => e.BrandName)
                    .HasName("NAME_UN")
                    .IsUnique();

                entity.Property(e => e.BrandId).HasColumnName("BRAND_ID");

                entity.Property(e => e.BrandC)
                    .IsRequired()
                    .HasColumnName("BRAND_C")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("BRAND_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Musterija>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("MUSTERIJA_PK");

                entity.ToTable("MUSTERIJA");

                entity.Property(e => e.CId).HasColumnName("C_ID");

                entity.Property(e => e.CfName)
                    .IsRequired()
                    .HasColumnName("CF_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClName)
                    .IsRequired()
                    .HasColumnName("CL_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("BILL_PK");

                entity.ToTable("RACUN");

                entity.Property(e => e.BillId).HasColumnName("BILL_ID");

                entity.Property(e => e.BillDate)
                    .HasColumnName("BILL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillPrice).HasColumnName("BILL_PRICE");

                entity.Property(e => e.Musterija).HasColumnName("MUSTERIJA");

                entity.Property(e => e.Stavka).HasColumnName("STAVKA");

                entity.HasOne(d => d.MusterijaNavigation)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.Musterija)
                    .HasConstraintName("MUSTERIJA_FK");

                entity.HasOne(d => d.StavkaNavigation)
                    .WithMany(p => p.Racun)
                    .HasForeignKey(d => d.Stavka)
                    .HasConstraintName("RACUN_FK");
            });

            modelBuilder.Entity<Radnja>(entity =>
            {
                entity.ToTable("RADNJA");

                entity.Property(e => e.RadnjaId)
                    .HasColumnName("RADNJA_ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.RadnjaNavigation)
                    .WithOne(p => p.Radnja)
                    .HasForeignKey<Radnja>(d => d.RadnjaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RADNJA__RADNJA_I__286302EC");
            });

            modelBuilder.Entity<Radnjaautomobil>(entity =>
            {
                entity.HasKey(e => new { e.RadId, e.AutoId })
                    .HasName("AUTOCEN_PK");

                entity.ToTable("RADNJAAUTOMOBIL");

                entity.Property(e => e.RadId).HasColumnName("RAD_ID");

                entity.Property(e => e.AutoId).HasColumnName("AUTO_ID");

                entity.HasOne(d => d.Auto)
                    .WithMany(p => p.Radnjaautomobil)
                    .HasForeignKey(d => d.AutoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RADNJAAUT__AUTO___37A5467C");

                entity.HasOne(d => d.Rad)
                    .WithMany(p => p.Radnjaautomobil)
                    .HasForeignKey(d => d.RadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RADNJAAUT__RAD_I__36B12243");
            });

            modelBuilder.Entity<Radnomjesto>(entity =>
            {
                entity.HasKey(e => e.WsId)
                    .HasName("WORKSPACE_PK");

                entity.ToTable("RADNOMJESTO");

                entity.Property(e => e.WsId).HasColumnName("WS_ID");

                entity.Property(e => e.WsName)
                    .IsRequired()
                    .HasColumnName("WS_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servis>(entity =>
            {
                entity.ToTable("SERVIS");

                entity.Property(e => e.ServisId)
                    .HasColumnName("SERVIS_ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ServisNavigation)
                    .WithOne(p => p.Servis)
                    .HasForeignKey<Servis>(d => d.ServisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SERVIS__SERVIS_I__2B3F6F97");
            });

            modelBuilder.Entity<Servismusterija>(entity =>
            {
                entity.HasKey(e => new { e.SId, e.MId })
                    .HasName("SM_PK");

                entity.ToTable("SERVISMUSTERIJA");

                entity.Property(e => e.SId).HasColumnName("S_ID");

                entity.Property(e => e.MId).HasColumnName("M_ID");

                entity.HasOne(d => d.M)
                    .WithMany(p => p.Servismusterija)
                    .HasForeignKey(d => d.MId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SERVISMUST__M_ID__3D5E1FD2");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.Servismusterija)
                    .HasForeignKey(d => d.SId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SERVISMUST__S_ID__3C69FB99");
            });

            modelBuilder.Entity<Stavka>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("STAVKA_PK");

                entity.ToTable("STAVKA");

                entity.Property(e => e.ItemId).HasColumnName("ITEM_ID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Cenovnik).HasColumnName("CENOVNIK");

                entity.Property(e => e.ItemPrice).HasColumnName("ITEM_PRICE");

                entity.HasOne(d => d.CenovnikNavigation)
                    .WithMany(p => p.Stavka)
                    .HasForeignKey(d => d.Cenovnik)
                    .HasConstraintName("CEN_FK");
            });

            modelBuilder.Entity<Zaposleni>(entity =>
            {
                entity.HasKey(e => e.WId)
                    .HasName("WORKER_PK");

                entity.ToTable("ZAPOSLENI");

                entity.Property(e => e.WId).HasColumnName("W_ID");

                entity.Property(e => e.RmId).HasColumnName("RM_ID");

                entity.Property(e => e.WfName)
                    .IsRequired()
                    .HasColumnName("WF_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WlName)
                    .IsRequired()
                    .HasColumnName("WL_NAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rm)
                    .WithMany(p => p.Zaposleni)
                    .HasForeignKey(d => d.RmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RM_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

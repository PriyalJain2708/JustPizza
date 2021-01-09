using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiCorePizza.Models
{
    public partial class DemoContext : DbContext
    {
        //public DemoContext()
        //{
        //}

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<TblPizzadetail> TblPizzadetails { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //               
                DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Demo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblPizzadetail>(entity =>
            {
                entity.HasKey(e => e.PizzaId);

                entity.ToTable("tbl_pizzadetails");

                entity.Property(e => e.PizzaId)
                    .ValueGeneratedNever()
                    .HasColumnName("Pizza_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ImageSrc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("imageSrc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.ReviewCount).HasColumnName("reviewCount");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Paswd)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

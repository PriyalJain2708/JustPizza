using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PizzaCoreApi.Models
{
    public partial class DemoContext : DbContext
    {
        /* public DemoContext()
         {
         }
        */

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerDetailList> CustomerDetailLists { get; set; }
        public virtual DbSet<PizzaFact> PizzaFacts { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }

        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              if (!optionsBuilder.IsConfigured)
              {
  #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                  optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Demo;Integrated Security=True");
              }
          }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CustomerDetailList>(entity =>
            {
                entity.HasKey(e => e.CustomerName)
                    .HasName("PK__Customer__7A22C6EB33D298EF");

                entity.ToTable("CustomerDetailList");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Dob)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DOB");

                entity.Property(e => e.Paswd)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PizzaFact>(entity =>
            {
                entity.HasKey(e => e.PizzaId)
                    .HasName("PK__PizzaFac__8D992E243EE06B55");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("category");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Imagesrc)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("imagesrc");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rating");

                entity.Property(e => e.ReviewCount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("reviewCount");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.ZipCode).HasColumnName("zipCode");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
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
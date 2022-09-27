using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApI_2.models
{
    public partial class CustomerDbContext : DbContext
    {
        public CustomerDbContext()
        {
        }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCustomer> TblCustomers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-47BMRRJ;Initial Catalog=CustomerDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblCustomer");

                entity.Property(e => e.CustomerAmount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CustomerCode).HasMaxLength(200);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

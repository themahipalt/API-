using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandsOnMVCWithEF.Entities
{
    public partial class RMSDBContext : DbContext
    {
        public RMSDBContext()
        {
        }

        public RMSDBContext(DbContextOptions<RMSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=RMSDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.ProjectCode, "IX_Employee_ProjectCode");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ProjectCodeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProjectCode);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectCode);

                entity.ToTable("Project");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

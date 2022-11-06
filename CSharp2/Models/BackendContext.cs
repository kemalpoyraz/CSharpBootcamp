using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace CSharp2.Models
{
    using static System.Data.Entity.DbContext;

    public class BackendContext : DbContext
    {
        public BackendContext() { }

        public BackendContext(DbContextOptions<BackendContext> options) : base(options) { }

        public DbSet<Student>? Students { get; set; }
        public DbSet<Grade>? Grades { get; set; }
        public DbSet<Notes>? Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CSHARP;Database=DbBackend;User Id=sa;Password=");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("tblStudent");
                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(x => x.StudentName).IsRequired().HasMaxLength(50);
                entity.Property(x => x.CreatedAt).HasDefaultValue(0);
                entity.Property(x => x.UpdatedAt).HasColumnType("date").HasDefaultValue("1900-01-01");
            });

            
        }
    }
}


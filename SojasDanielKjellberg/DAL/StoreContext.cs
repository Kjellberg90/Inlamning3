using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Campaign> Campaigns {  get; set; }
        public DbSet<ProductDepartement> ProductsDepartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = @"Server=DESKTOP-DVPQU84\SQLEXPRESS;Database=DanielKjellberg;Integrated Security=True;";
            builder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId)
                ;

            modelBuilder.Entity<Product>()
                .HasOne(s => s.Staff)
                .WithMany(p => p.Product)
                ;

            modelBuilder.Entity<Department>()
                .HasKey(d => d.DepartmentId)
                ;

            modelBuilder.Entity<Department>()
                .HasOne(s => s.Staff)
                .WithMany(d => d.Department)
                .IsRequired()
                ;

            modelBuilder.Entity<Staff>()
                .HasKey(s => s.StaffId)
                ;

            modelBuilder.Entity<Staff>()
                .HasIndex(s => s.Ssn).IsUnique();
                ;

            modelBuilder.Entity<Staff>()
                .HasOne(s => s.Mentor)
                .WithMany(s => s.Pupil)
                .HasForeignKey(s => s.MentorID)
                .OnDelete(DeleteBehavior.ClientCascade)
                ;

            modelBuilder.Entity<Campaign>()
                .HasKey(c => c.CampaignId)
                ;

            modelBuilder.Entity<Campaign>()
                .HasMany(p => p.Product)
                .WithOne(c => c.Campaign)
                ;

            modelBuilder.Entity<ProductDepartement>().
                HasKey(pd => new { pd.ProductId, pd.DepartmentId })
                ;

            modelBuilder.Entity<ProductDepartement>()
                .HasOne(pd => pd.Product)
                .WithMany(p => p.ProductDepartements)
                .HasForeignKey(pd => pd.ProductId)
                .OnDelete(DeleteBehavior.ClientNoAction)
            ;

            modelBuilder.Entity<ProductDepartement>()
                .HasOne(pd => pd.Department)
                .WithMany(p => p.ProductDepartements)
                .HasForeignKey(pd => pd.DepartmentId)
                .OnDelete(DeleteBehavior.ClientNoAction)
                ;
        }
    }
}

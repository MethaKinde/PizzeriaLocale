using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PizzeriaLocale.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderSummary> OrderSummaries { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<RoleManager> RoleManagers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);
        }
    }
}

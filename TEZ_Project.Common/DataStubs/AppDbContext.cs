using System.Data.Entity;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Const> Consts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Basic configuration - can be extended later
            base.OnModelCreating(modelBuilder);
        }
    }
}

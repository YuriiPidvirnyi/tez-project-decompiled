using System.Data.Entity;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Data;

public class AppDbContext : DbContext
{
	public DbSet<Order> Orders { get; set; }

	public DbSet<Product> Products { get; set; }

	public DbSet<Const> Consts { get; set; }

	public DbSet<CustomProduct> CustomProducts { get; set; }

	public DbSet<CustomProductConsts> CustomProductConsts { get; set; }

	public DbSet<User> Users { get; set; }

	public AppDbContext()
		: base("DefaultConnection")
	{
	}
}

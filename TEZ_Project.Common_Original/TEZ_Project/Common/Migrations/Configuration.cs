using System.Data.Entity.Migrations;
using TEZ_Project.Common.Data;

namespace TEZ_Project.Common.Migrations;

internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
{
	public Configuration()
	{
		base.AutomaticMigrationsEnabled = false;
	}

	protected override void Seed(AppDbContext context)
	{
	}
}

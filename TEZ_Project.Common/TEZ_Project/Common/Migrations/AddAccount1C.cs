using System.CodeDom.Compiler;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Builders;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace TEZ_Project.Common.Migrations;

[GeneratedCode("EntityFramework.Migrations", "6.4.4")]
public sealed class AddAccount1C : DbMigration, IMigrationMetadata
{
	private readonly ResourceManager Resources = new ResourceManager(typeof(AddAccount1C));

	string IMigrationMetadata.Id => "202206291618122_AddAccount1C";

	string IMigrationMetadata.Source => null;

	string IMigrationMetadata.Target => Resources.GetString("Target");

	public override void Up()
	{
		AddColumn("dbo.Orders", "Account1C", (ColumnBuilder c) => c.String());
	}

	public override void Down()
	{
		DropColumn("dbo.Orders", "Account1C");
	}
}

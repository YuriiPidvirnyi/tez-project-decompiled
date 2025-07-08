using System;
using System.CodeDom.Compiler;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Builders;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Linq.Expressions;
using System.Reflection;
using System.Resources;

namespace TEZ_Project.Common.Migrations;

[GeneratedCode("EntityFramework.Migrations", "6.4.4")]
public sealed class AddCustomProduct : DbMigration, IMigrationMetadata
{
	private readonly ResourceManager Resources = new ResourceManager(typeof(AddCustomProduct));

	string IMigrationMetadata.Id => "202301251541121_AddCustomProduct";

	string IMigrationMetadata.Source => null;

	string IMigrationMetadata.Target => Resources.GetString("Target");

	public override void Up()
	{
		var tableBuilder = CreateTable("dbo.CustomProductConsts", (ColumnBuilder c) => new
		{
			Id = c.Int(false, identity: true),
			MaterialSpending = c.Double(false),
			ConstId = c.Int(false),
			CustomProductId = c.Int(false)
		});
		ParameterExpression val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder2 = tableBuilder.PrimaryKey(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder3 = tableBuilder2.ForeignKey("dbo.Consts", Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }), cascadeDelete: true);
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder4 = tableBuilder3.ForeignKey("dbo.CustomProducts", Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }), cascadeDelete: true);
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder5 = tableBuilder4.Index(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		tableBuilder5.Index(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType4<ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		var tableBuilder6 = CreateTable("dbo.CustomProducts", (ColumnBuilder c) => new
		{
			Id = c.Int(false, identity: true),
			Name = c.String(),
			CreatedBy = c.String(),
			LastUpdatedBy = c.String(),
			LastUpdatedDate = c.DateTime(false)
		});
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType5<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		tableBuilder6.PrimaryKey(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType5<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
	}

	public override void Down()
	{
		DropForeignKey("dbo.CustomProductConsts", "CustomProductId", "dbo.CustomProducts");
		DropForeignKey("dbo.CustomProductConsts", "ConstId", "dbo.Consts");
		DropIndex("dbo.CustomProductConsts", new string[1] { "CustomProductId" });
		DropIndex("dbo.CustomProductConsts", new string[1] { "ConstId" });
		DropTable("dbo.CustomProducts");
		DropTable("dbo.CustomProductConsts");
	}
}

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
public sealed class initial : DbMigration, IMigrationMetadata
{
	private readonly ResourceManager Resources = new ResourceManager(typeof(initial));

	string IMigrationMetadata.Id => "202103021729030_initial";

	string IMigrationMetadata.Source => null;

	string IMigrationMetadata.Target => Resources.GetString("Target");

	public override void Up()
	{
		var tableBuilder = CreateTable("dbo.Consts", (ColumnBuilder c) => new
		{
			Id = c.Int(false, identity: true),
			NameInApp = c.String(),
			MaterialName = c.String(),
			Price = c.Double(false),
			MaterialNameFlight = c.String(),
			Code1 = c.String(),
			MaterialName1C = c.String(),
			Code2 = c.String(),
			OdVym1 = c.String(),
			OdVym2 = c.String()
		});
		ParameterExpression val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType0<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		tableBuilder.PrimaryKey(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType0<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		var tableBuilder2 = CreateTable("dbo.Orders", (ColumnBuilder c) => new
		{
			Id = c.Int(false, identity: true),
			Date = c.DateTime(false),
			Status = c.Int(false),
			Priority = c.Int(false),
			Contragent = c.String(),
			PercentFor1C = c.Int(false),
			Code = c.String(),
			ManagerId = c.Int(false)
		});
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType1<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder3 = tableBuilder2.PrimaryKey(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType1<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType1<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder4 = tableBuilder3.ForeignKey("dbo.Users", Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType1<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }), cascadeDelete: true);
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType1<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		tableBuilder4.Index(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType1<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		var tableBuilder5 = CreateTable("dbo.Users", (ColumnBuilder c) => new
		{
			Id = c.Int(false, identity: true),
			Login = c.String(),
			Password = c.String(),
			PasswordSetDate = c.DateTime(false),
			Role = c.Int(false),
			IsPasswordReset = c.Boolean(false)
		});
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType2<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		tableBuilder5.PrimaryKey(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType2<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		var tableBuilder6 = CreateTable("dbo.Products", (ColumnBuilder c) => new
		{
			Id = c.Int(false, identity: true),
			Type = c.String(),
			Data = c.String(),
			OrderId = c.Int(false),
			Price = c.Double(false)
		});
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType3<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder7 = tableBuilder6.PrimaryKey(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType3<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType3<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		var tableBuilder8 = tableBuilder7.ForeignKey("dbo.Orders", Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType3<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }), cascadeDelete: true);
		val = Expression.Parameter(typeof(_003C_003Ef__AnonymousType3<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>), "t");
		tableBuilder8.Index(Expression.Lambda((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType3<ColumnModel, ColumnModel, ColumnModel, ColumnModel, ColumnModel>).TypeHandle)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
	}

	public override void Down()
	{
		DropForeignKey("dbo.Products", "OrderId", "dbo.Orders");
		DropForeignKey("dbo.Orders", "ManagerId", "dbo.Users");
		DropIndex("dbo.Products", new string[1] { "OrderId" });
		DropIndex("dbo.Orders", new string[1] { "ManagerId" });
		DropTable("dbo.Products");
		DropTable("dbo.Users");
		DropTable("dbo.Orders");
		DropTable("dbo.Consts");
	}
}

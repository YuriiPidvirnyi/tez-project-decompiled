using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Data;

public class CustomProductRepository
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public string name;
	}

	private readonly AppDbContext _db;

	public CustomProductRepository(AppDbContext db)
	{
		_db = db;
	}

	public virtual Task<List<CustomProductModel>> GetAllAsync()
	{
		DbSet<CustomProduct> customProducts = _db.CustomProducts;
		ParameterExpression val = Expression.Parameter(typeof(CustomProduct), "cp");
		IQueryable<CustomProductModel> obj = Queryable.Select<CustomProduct, CustomProductModel>((IQueryable<CustomProduct>)customProducts, Expression.Lambda<Func<CustomProduct, CustomProductModel>>((Expression)(object)Expression.MemberInit(Expression.New(typeof(CustomProductModel)), (MemberBinding[])(object)new MemberBinding[5]
		{
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)))
		}), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(CustomProductModel), "cp");
		return ((IQueryable<CustomProductModel>)(object)Queryable.OrderBy<CustomProductModel, string>(obj, Expression.Lambda<Func<CustomProductModel, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }))).ToListAsync<CustomProductModel>();
	}

	public virtual CustomProduct GetByName(string name)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.name = name;
		DbSet<CustomProduct> customProducts = _db.CustomProducts;
		ParameterExpression val = Expression.Parameter(typeof(CustomProduct), "cp");
		IQueryable<CustomProduct> source = customProducts.Include<CustomProduct, ICollection<CustomProductConsts>>(Expression.Lambda<Func<CustomProduct, ICollection<CustomProductConsts>>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(CustomProduct), "cp");
		MethodInfo obj = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		Expression[] obj2 = new Expression[2]
		{
			(Expression)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)),
			default(Expression)
		};
		ParameterExpression val2 = Expression.Parameter(typeof(CustomProductConsts), "cpc");
		obj2[1] = (Expression)Expression.Lambda<Func<CustomProductConsts, Const>>((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 });
		IQueryable<CustomProduct> obj3 = source.Include<CustomProduct, IEnumerable<Const>>(Expression.Lambda<Func<CustomProduct, IEnumerable<Const>>>((Expression)(object)Expression.Call((Expression)null, obj, (Expression[])(object)obj2), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(CustomProduct), "cp");
		return Queryable.FirstOrDefault<CustomProduct>(obj3, Expression.Lambda<Func<CustomProduct, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
	}

	public virtual List<string> GetAllNames()
	{
		DbSet<CustomProduct> customProducts = _db.CustomProducts;
		ParameterExpression val = Expression.Parameter(typeof(CustomProduct), "x");
		IQueryable<string> obj = Queryable.Select<CustomProduct, string>((IQueryable<CustomProduct>)customProducts, Expression.Lambda<Func<CustomProduct, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(string), "x");
		return Enumerable.ToList<string>((IEnumerable<string>)Queryable.OrderBy<string, string>(obj, Expression.Lambda<Func<string, string>>((Expression)(object)val, (ParameterExpression[])(object)new ParameterExpression[1] { val })));
	}

	public virtual void Insert(CustomProduct newCustomProduct)
	{
		_db.CustomProducts.Add(newCustomProduct);
	}

	public virtual void DeleteById(int id)
	{
		CustomProduct entityToDelete = _db.CustomProducts.Find(id);
		Delete(entityToDelete);
	}

	public virtual void Delete(CustomProduct entityToDelete)
	{
		if (_db.Entry(entityToDelete).State == EntityState.Detached)
		{
			_db.CustomProducts.Attach(entityToDelete);
		}
		_db.CustomProducts.Remove(entityToDelete);
	}

	public virtual void DeleteCustomProductConsts(ICollection<CustomProductConsts> customProductConsts)
	{
		_db.CustomProductConsts.RemoveRange(customProductConsts);
	}

	public virtual void Update(CustomProduct productToUpdate)
	{
		_db.CustomProducts.Attach(productToUpdate);
		_db.Entry(productToUpdate).State = EntityState.Modified;
	}
}

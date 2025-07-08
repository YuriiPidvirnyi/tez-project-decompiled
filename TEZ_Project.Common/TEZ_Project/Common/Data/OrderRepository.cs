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

public class OrderRepository
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public int id;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public IEnumerable<int> ids;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public DateTime? dateFrom;

		public DateTime? dateTo;
	}

	private readonly AppDbContext _db;

	public OrderRepository(AppDbContext db)
	{
		_db = db;
	}

	public Order AddOrder(Order order)
	{
		order.Date = DateTime.Now;
		_db.Orders.Add(order);
		return order;
	}

	public virtual Order GetById(int id)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.id = id;
		DbSet<Order> orders = _db.Orders;
		ParameterExpression val = Expression.Parameter(typeof(Order), "o");
		IQueryable<Order> obj = orders.Include<Order, ICollection<Product>>(Expression.Lambda<Func<Order, ICollection<Product>>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(Order), "o");
		return Queryable.FirstOrDefault<Order>(obj, Expression.Lambda<Func<Order, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
	}

	public virtual List<Order> GetByIds(IEnumerable<int> ids)
	{
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
		_003C_003Ec__DisplayClass4_.ids = ids;
		DbSet<Order> orders = _db.Orders;
		ParameterExpression val = Expression.Parameter(typeof(Order), "o");
		IQueryable<Order> obj = orders.Include<Order, ICollection<Product>>(Expression.Lambda<Func<Order, ICollection<Product>>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(Order), "o");
		return Enumerable.ToList<Order>((IEnumerable<Order>)Queryable.Where<Order>(obj, Expression.Lambda<Func<Order, bool>>((Expression)(object)Expression.Call((Expression)null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[2]
		{
			(Expression)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass4_, typeof(_003C_003Ec__DisplayClass4_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
			(Expression)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))
		}), (ParameterExpression[])(object)new ParameterExpression[1] { val })));
	}

	public virtual void Insert(Order entity)
	{
		_db.Orders.Add(entity);
	}

	public virtual void Delete(int id)
	{
		Order entityToDelete = _db.Orders.Find(id);
		Delete(entityToDelete);
	}

	public virtual async Task<ICollection<OrderModel>> GetOrdersAsync(DateTime? dateFrom = null, DateTime? dateTo = null)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.dateFrom = dateFrom;
		_003C_003Ec__DisplayClass7_.dateTo = dateTo;
		DbSet<Order> orders2 = _db.Orders;
		ParameterExpression val = Expression.Parameter(typeof(Order), "o");
		NewExpression obj = Expression.New(typeof(OrderModel));
		MemberBinding[] obj2 = new MemberBinding[12]
		{
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			(MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))),
			default(MemberBinding),
			default(MemberBinding)
		};
		MethodInfo obj3 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		MethodInfo obj4 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
		Expression[] obj5 = new Expression[2]
		{
			(Expression)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)),
			default(Expression)
		};
		ParameterExpression val2 = Expression.Parameter(typeof(Product), "p");
		obj5[1] = (Expression)Expression.Lambda<Func<Product, double>>((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 });
		obj2[10] = (MemberBinding)Expression.Bind(obj3, (Expression)(object)Expression.Convert((Expression)(object)Expression.Call((Expression)null, obj4, (Expression[])(object)obj5), typeof(double?)));
		obj2[11] = (MemberBinding)Expression.Bind((MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)));
		IQueryable<OrderModel> query2 = Queryable.Select<Order, OrderModel>((IQueryable<Order>)orders2, Expression.Lambda<Func<Order, OrderModel>>((Expression)(object)Expression.MemberInit(obj, (MemberBinding[])(object)obj2), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		if (_003C_003Ec__DisplayClass7_.dateFrom.HasValue)
		{
			IQueryable<OrderModel> obj6 = query2;
			val = Expression.Parameter(typeof(OrderModel), "o");
			query2 = Queryable.Where<OrderModel>(obj6, Expression.Lambda<Func<OrderModel, bool>>((Expression)(object)Expression.GreaterThanOrEqual((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Property((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass7_, typeof(_003C_003Ec__DisplayClass7_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(DateTime?).TypeHandle)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		}
		if (_003C_003Ec__DisplayClass7_.dateTo.HasValue)
		{
			IQueryable<OrderModel> obj7 = query2;
			val = Expression.Parameter(typeof(OrderModel), "o");
			query2 = Queryable.Where<OrderModel>(obj7, Expression.Lambda<Func<OrderModel, bool>>((Expression)(object)Expression.LessThanOrEqual((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Property((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass7_, typeof(_003C_003Ec__DisplayClass7_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(DateTime?).TypeHandle)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		}
		IQueryable<OrderModel> obj8 = query2;
		val = Expression.Parameter(typeof(OrderModel), "p");
		query2 = (IQueryable<OrderModel>)(object)Queryable.OrderByDescending<OrderModel, DateTime>(obj8, Expression.Lambda<Func<OrderModel, DateTime>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		List<OrderModel> allOrders = new List<OrderModel>();
		int skip = 0;
		bool hasMore;
		do
		{
			List<OrderModel> orders = await Queryable.Take<OrderModel>(Queryable.Skip<OrderModel>(query2, skip), 1000).ToListAsync<OrderModel>();
			allOrders.AddRange(orders);
			hasMore = orders.Count == 1000;
			skip += 1000;
		}
		while (hasMore);
		return allOrders;
	}

	public virtual void Delete(Order entityToDelete)
	{
		if (_db.Entry(entityToDelete).State == EntityState.Detached)
		{
			_db.Orders.Attach(entityToDelete);
		}
		_db.Orders.Remove(entityToDelete);
	}

	public virtual void Update(Order entityToUpdate)
	{
		_db.Orders.Attach(entityToUpdate);
		_db.Entry(entityToUpdate).State = EntityState.Modified;
	}
}

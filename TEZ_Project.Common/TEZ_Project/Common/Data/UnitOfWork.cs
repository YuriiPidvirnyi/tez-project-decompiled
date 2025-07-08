using System;
using TEZ_Project.Common.Data.Repositories;

namespace TEZ_Project.Common.Data;

public class UnitOfWork : IDisposable
{
	private AppDbContext _context = new AppDbContext();

	private ProductRepository _productRepository;

	private OrderRepository _orderRepository;

	private ConstRepository _constRepository;

	private CustomProductRepository _customProductRepository;

	private UserRepository _userRepository;

	private bool disposed = false;

	public ProductRepository ProductRepository
	{
		get
		{
			if (_productRepository == null)
			{
				_productRepository = new ProductRepository(_context);
			}
			return _productRepository;
		}
	}

	public OrderRepository OrderRepository
	{
		get
		{
			if (_orderRepository == null)
			{
				_orderRepository = new OrderRepository(_context);
			}
			return _orderRepository;
		}
	}

	public ConstRepository ConstRepository
	{
		get
		{
			if (_constRepository == null)
			{
				_constRepository = new ConstRepository(_context);
			}
			return _constRepository;
		}
	}

	public CustomProductRepository CustomProductRepository => _customProductRepository ?? new CustomProductRepository(_context);

	public UserRepository UserRepository
	{
		get
		{
			if (_userRepository == null)
			{
				_userRepository = new UserRepository(_context);
			}
			return _userRepository;
		}
	}

	public void Save()
	{
		_context.SaveChanges();
	}

	public void ReseedTable(string tableName)
	{
		_context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('" + tableName + "', RESEED, 0)");
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed && disposing)
		{
			_context.Dispose();
		}
		disposed = true;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}

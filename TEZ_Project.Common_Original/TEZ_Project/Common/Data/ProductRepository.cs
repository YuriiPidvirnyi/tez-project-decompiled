using System.Data.Entity;
using TEZ_Project.Common.Data.Entities;
using TEZ_Project.Common.Helpers;
using TEZ_Project.Common.Models;

namespace TEZ_Project.Common.Data;

public class ProductRepository
{
	private readonly AppDbContext _db;

	public ProductRepository(AppDbContext db)
	{
		_db = db;
	}

	public virtual IProduct GetById(int id)
	{
		return _db.Products.Find(id).ToProduct();
	}

	public virtual void Insert(Product productToInsert, int orderId)
	{
		_db.Products.Add(productToInsert);
	}

	public virtual void Delete(int id)
	{
		Product entityToDelete = _db.Products.Find(id);
		Delete(entityToDelete);
	}

	public virtual void Delete(Product entityToDelete)
	{
		if (_db.Entry(entityToDelete).State == EntityState.Detached)
		{
			_db.Products.Attach(entityToDelete);
		}
		_db.Products.Remove(entityToDelete);
	}

	public virtual void Update(Product productToUpdate)
	{
		_db.Products.Attach(productToUpdate);
		_db.Entry(productToUpdate).State = EntityState.Modified;
	}
}

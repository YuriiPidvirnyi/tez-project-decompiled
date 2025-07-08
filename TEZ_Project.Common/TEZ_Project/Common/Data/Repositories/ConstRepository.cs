using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Data.Repositories;

public class ConstRepository
{
	private readonly AppDbContext _db;

	public ConstRepository(AppDbContext db)
	{
		_db = db;
	}

	public virtual void Add(Const @const)
	{
		_db.Consts.Add(@const);
	}

	public virtual IEnumerable<Const> GetAll()
	{
		return Enumerable.ToList<Const>((IEnumerable<Const>)_db.Consts);
	}

	public virtual void Update(Const @const)
	{
		_db.Consts.Attach(@const);
		_db.Entry(@const).State = EntityState.Modified;
	}

	public virtual void Delete(int id)
	{
		Const entityToDelete = _db.Consts.Find(id);
		Delete(entityToDelete);
	}

	public virtual void Delete(Const entityToDelete)
	{
		if (_db.Entry(entityToDelete).State == EntityState.Detached)
		{
			_db.Consts.Attach(entityToDelete);
		}
		_db.Consts.Remove(entityToDelete);
	}
}

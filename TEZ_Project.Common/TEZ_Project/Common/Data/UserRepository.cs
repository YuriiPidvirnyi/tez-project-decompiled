using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Data;

public class UserRepository
{
	private readonly AppDbContext _db;

	public UserRepository(AppDbContext db)
	{
		_db = db;
	}

	public virtual IEnumerable<User> GetAll()
	{
		return Enumerable.ToList<User>((IEnumerable<User>)_db.Users);
	}

	public virtual User GetById(int id)
	{
		return _db.Users.Find(id);
	}

	public virtual void Insert(User user)
	{
		_db.Users.Add(user);
	}

	public virtual void Delete(int id)
	{
		User entityToDelete = _db.Users.Find(id);
		Delete(entityToDelete);
	}

	public virtual void Delete(User entityToDelete)
	{
		if (_db.Entry(entityToDelete).State == EntityState.Detached)
		{
			_db.Users.Attach(entityToDelete);
		}
		_db.Users.Remove(entityToDelete);
	}

	public virtual void Update(User userToUpdate)
	{
		_db.Users.Attach(userToUpdate);
		_db.Entry(userToUpdate).State = EntityState.Modified;
	}
}

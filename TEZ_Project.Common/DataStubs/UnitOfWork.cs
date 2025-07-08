using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEZ_Project.Common.Data.Entities;

namespace TEZ_Project.Common.Data
{
    public class UnitOfWork : IDisposable
    {
        public IRepository<Const> ConstRepository { get; private set; }

        public IRepository<CustomProduct> CustomProductRepository { get; private set; }

        public UnitOfWork()
        {
            ConstRepository = new ConstRepository();
            CustomProductRepository = new CustomProductRepository();
        }

        public void Save()
        {
            // Stub implementation
        }

        public void ReseedTable(string tableName)
        {
            // Stub implementation
        }

        public void Dispose()
        {
            // Stub implementation
        }
    }

    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
    }

    public class ConstRepository : IRepository<Const>
    {
        private static List<Const> _consts = new List<Const>();

        public IEnumerable<Const> GetAll()
        {
            return _consts;
        }

        public void Add(Const entity)
        {
            _consts.Add(entity);
        }

        public void Delete(Const entity)
        {
            _consts.Remove(entity);
        }
    }

    public class CustomProductRepository : IRepository<CustomProduct>
    {
private static List<CustomProduct> _products = new List<CustomProduct>();

public Task<ICollection<CustomProduct>> GetAllAsync()
{
    return Task.FromResult<ICollection<CustomProduct>>(_products);
}

        public IEnumerable<CustomProduct> GetAll()
        {
            return _products;
        }

public CustomProduct GetByName(string name)
{
    return _products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
}

public void Insert(CustomProduct entity)
{
    _products.Add(entity);
}

public void DeleteCustomProductConsts(List<CustomProductConsts> consts)
{
    // Logic to remove related CustomProductConsts
}

public void Add(CustomProduct entity)
{
    _products.Add(entity);
}

        public void Delete(CustomProduct entity)
        {
            _products.Remove(entity);
        }
    }
}

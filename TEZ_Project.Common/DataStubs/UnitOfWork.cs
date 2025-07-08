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
        public IRepository<User> UserRepository { get; private set; }
        public OrderRepository OrderRepository { get; private set; }
        public IRepository<object> ProductRepository { get; private set; }

        public UnitOfWork()
        {
            ConstRepository = new ConstRepository();
            CustomProductRepository = new CustomProductRepository();
            UserRepository = new UserRepository();
            OrderRepository = new OrderRepository(new AppDbContext());
            ProductRepository = new ProductRepository();
        }

        public void Save()
        {
            // Stub implementation
        }

        public static void ReseedTable(string tableName)
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
        Task<ICollection<T>> GetAllAsync();
        T GetByName(string name);
        IEnumerable<string> GetAllNames();
        void Insert(T entity);
        void Insert(T entity, object parameter);
        void DeleteById(int id);
        void DeleteCustomProductConsts(List<CustomProductConsts> consts);
        T GetById(int id);
        void Update(T entity);
        Task<ICollection<T>> GetOrdersAsync(DateTime? dateFrom, DateTime? dateTo);
        void AddOrder(T entity);
        IEnumerable<T> GetByIds(IEnumerable<int> ids);
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

        public Task<ICollection<Const>> GetAllAsync()
        {
            return Task.FromResult<ICollection<Const>>(_consts);
        }

        public Const GetByName(string name)
        {
            return _consts.FirstOrDefault(c => c.MaterialName.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<string> GetAllNames()
        {
            return _consts.Select(c => c.MaterialName);
        }

        public void Insert(Const entity)
        {
            _consts.Add(entity);
        }

        public void Insert(Const entity, object parameter)
        {
            _consts.Add(entity);
        }

        public void DeleteById(int id)
        {
            var entity = _consts.FirstOrDefault(c => c.Id == id);
            if (entity != null)
                _consts.Remove(entity);
        }

        public void DeleteCustomProductConsts(List<CustomProductConsts> consts)
        {
            // Stub implementation for Const repository
        }

        public Const GetById(int id)
        {
            return _consts.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Const entity)
        {
            var existing = _consts.FirstOrDefault(c => c.Id == entity.Id);
            if (existing != null)
            {
                var index = _consts.IndexOf(existing);
                _consts[index] = entity;
            }
        }

        public Task<ICollection<Const>> GetOrdersAsync(DateTime? dateFrom, DateTime? dateTo)
        {
            return Task.FromResult<ICollection<Const>>(_consts);
        }

        public void AddOrder(Const entity)
        {
            _consts.Add(entity);
        }

        public IEnumerable<Const> GetByIds(IEnumerable<int> ids)
        {
            return _consts.Where(c => ids.Contains(c.Id));
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

        public void Insert(CustomProduct entity, object parameter)
        {
            _products.Add(entity);
        }

public void DeleteCustomProductConsts(List<CustomProductConsts> consts)
{
    // Logic to remove related CustomProductConsts
}

public IEnumerable<string> GetAllNames()
{
    return _products.Select(p => p.Name);
}

public void DeleteById(int id)
{
    var entity = _products.FirstOrDefault(p => p.Id == id);
    if (entity != null)
        _products.Remove(entity);
}

public void Add(CustomProduct entity)
{
    _products.Add(entity);
}

        public void Delete(CustomProduct entity)
        {
            _products.Remove(entity);
        }

        public CustomProduct GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(CustomProduct entity)
        {
            var existing = _products.FirstOrDefault(p => p.Id == entity.Id);
            if (existing != null)
            {
                var index = _products.IndexOf(existing);
                _products[index] = entity;
            }
        }

        public Task<ICollection<CustomProduct>> GetOrdersAsync(DateTime? dateFrom, DateTime? dateTo)
        {
            return Task.FromResult<ICollection<CustomProduct>>(_products);
        }

        public void AddOrder(CustomProduct entity)
        {
            _products.Add(entity);
        }

        public IEnumerable<CustomProduct> GetByIds(IEnumerable<int> ids)
        {
            return _products.Where(p => ids.Contains(p.Id));
        }
    }

    public class UserRepository : IRepository<User>
    {
        private static List<User> _users = new List<User>();

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Add(User entity)
        {
            _users.Add(entity);
        }

        public void Delete(User entity)
        {
            _users.Remove(entity);
        }

        public Task<ICollection<User>> GetAllAsync()
        {
            return Task.FromResult<ICollection<User>>(_users);
        }

        public User GetByName(string name)
        {
            return _users.FirstOrDefault(u => u.Login.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<string> GetAllNames()
        {
            return _users.Select(u => u.Login);
        }

        public void Insert(User entity)
        {
            _users.Add(entity);
        }

        public void Insert(User entity, object parameter)
        {
            _users.Add(entity);
        }

        public void DeleteById(int id)
        {
            var entity = _users.FirstOrDefault(u => u.Id == id);
            if (entity != null)
                _users.Remove(entity);
        }

        public void DeleteCustomProductConsts(List<CustomProductConsts> consts)
        {
            // Not applicable for User repository
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(User entity)
        {
            var existing = _users.FirstOrDefault(u => u.Id == entity.Id);
            if (existing != null)
            {
                var index = _users.IndexOf(existing);
                _users[index] = entity;
            }
        }

        public Task<ICollection<User>> GetOrdersAsync(DateTime? dateFrom, DateTime? dateTo)
        {
            return Task.FromResult<ICollection<User>>(_users);
        }

        public void AddOrder(User entity)
        {
            _users.Add(entity);
        }

        public IEnumerable<User> GetByIds(IEnumerable<int> ids)
        {
            return _users.Where(u => ids.Contains(u.Id));
        }
    }

    public class OrderRepositoryAdapter : IRepository<Order>
    {
        private static List<Order> _orders = new List<Order>();

        public IEnumerable<Order> GetAll()
        {
            return _orders;
        }

        public void Add(Order entity)
        {
            _orders.Add(entity);
        }

        public void Delete(Order entity)
        {
            _orders.Remove(entity);
        }

        public Task<ICollection<Order>> GetAllAsync()
        {
            return Task.FromResult<ICollection<Order>>(_orders);
        }

        public Order GetByName(string name)
        {
            return _orders.FirstOrDefault(o => o.Code.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<string> GetAllNames()
        {
            return _orders.Select(o => o.Code);
        }

        public void Insert(Order entity)
        {
            _orders.Add(entity);
        }

        public void Insert(Order entity, object parameter)
        {
            _orders.Add(entity);
        }

        public void DeleteById(int id)
        {
            var entity = _orders.FirstOrDefault(o => o.Id == id);
            if (entity != null)
                _orders.Remove(entity);
        }

        public void DeleteCustomProductConsts(List<CustomProductConsts> consts)
        {
            // Not applicable for Order repository
        }

        public Order GetById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public void Update(Order entity)
        {
            var existing = _orders.FirstOrDefault(o => o.Id == entity.Id);
            if (existing != null)
            {
                var index = _orders.IndexOf(existing);
                _orders[index] = entity;
            }
        }

        public Task<ICollection<Order>> GetOrdersAsync(DateTime? dateFrom, DateTime? dateTo)
        {
            var filteredOrders = _orders.AsEnumerable();
            if (dateFrom.HasValue)
                filteredOrders = filteredOrders.Where(o => o.Date >= dateFrom.Value);
            if (dateTo.HasValue)
                filteredOrders = filteredOrders.Where(o => o.Date <= dateTo.Value);
            return Task.FromResult<ICollection<Order>>(filteredOrders.ToList());
        }

        public void AddOrder(Order entity)
        {
            _orders.Add(entity);
        }

        public IEnumerable<Order> GetByIds(IEnumerable<int> ids)
        {
            return _orders.Where(o => ids.Contains(o.Id));
        }
    }

    public class ProductRepository : IRepository<object>
    {
        private static List<object> _products = new List<object>();

        public IEnumerable<object> GetAll()
        {
            return _products;
        }

        public void Add(object entity)
        {
            _products.Add(entity);
        }

        public void Delete(object entity)
        {
            _products.Remove(entity);
        }

        public Task<ICollection<object>> GetAllAsync()
        {
            return Task.FromResult<ICollection<object>>(_products);
        }

        public object GetByName(string name)
        {
            return _products.FirstOrDefault();
        }

        public IEnumerable<string> GetAllNames()
        {
            return new List<string>();
        }

        public void Insert(object entity)
        {
            _products.Add(entity);
        }

        public void Insert(object entity, object parameter)
        {
            _products.Add(entity);
        }

        public void DeleteById(int id)
        {
            // Stub implementation
        }

        public void DeleteCustomProductConsts(List<CustomProductConsts> consts)
        {
            // Not applicable for Product repository
        }

        public object GetById(int id)
        {
            return _products.FirstOrDefault();
        }

        public void Update(object entity)
        {
            // Stub implementation
        }

        public Task<ICollection<object>> GetOrdersAsync(DateTime? dateFrom, DateTime? dateTo)
        {
            return Task.FromResult<ICollection<object>>(_products);
        }

        public void AddOrder(object entity)
        {
            _products.Add(entity);
        }

        public IEnumerable<object> GetByIds(IEnumerable<int> ids)
        {
            return _products;
        }
    }
}

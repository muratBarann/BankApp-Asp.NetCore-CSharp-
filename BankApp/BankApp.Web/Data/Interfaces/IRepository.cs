using System.Collections.Generic;
using System.Linq;

namespace BankApp.Web.Data.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        public void Create(T entity);
        public void Remove(T entity);
        public List<T> GetAll();
        public T GetById(object id);
        public void Update(T entity);
        IQueryable<T> GetQueryable();

    }
}

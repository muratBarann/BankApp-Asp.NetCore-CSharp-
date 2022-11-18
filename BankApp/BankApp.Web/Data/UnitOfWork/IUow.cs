using BankApp.Web.Data.Interfaces;

namespace BankApp.Web.Data.UnitOfWork
{
    public interface IUow
    {
        public IRepository<T> GetRepository<T>() where T : class, new();
        public void SaveChanges();


    }
}
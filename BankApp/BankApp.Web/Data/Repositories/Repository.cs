using BankApp.Web.Data.Context;
using BankApp.Web.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BankApp.Web.Data.Repositories
{

    //Generic Repository amacı her bir entity için dataya erişme metodu yazmamak için GR Yazıyoruz
    public class Repository<T>: IRepository<T> where T : class, new()       //T'ye kısıtlama koyduk class olmalı ve newlene bilmeli static yada abstract olamamlı diye
    {
        private readonly BankContext _context;

        public Repository(BankContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        //IQuerayable => db tarafında iş bitmemiş
        //yani where, find gibi koşullar daha gerçekleşmemiş ilgili değişikşik hala yapabilirim
        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }




    }
}

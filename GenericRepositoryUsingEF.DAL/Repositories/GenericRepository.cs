using GenericRepositoryUsingEF.DAL.Contracts;
using GenericRepositoryUsingEF.DAL.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUsingEF.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private EmployeeDataModel _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new EmployeeDataModel();
            table = _context.Set<T>();
        }
        public GenericRepository(EmployeeDataModel _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return table.AsQueryable();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public bool Insert(T obj)
        {
            table.Add(obj);
            return true;
        }
        public bool Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            return true;
        }
        public bool Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            return true;
        }
        public bool Save()
        {
            _context.SaveChanges();
            return true;
        }
    }
}

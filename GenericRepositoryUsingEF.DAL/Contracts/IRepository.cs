using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUsingEF.DAL.Contracts
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(object id);
        bool Insert(T obj);
        bool Update(T obj);
        bool Delete(object id);
        bool Save();
    }
}

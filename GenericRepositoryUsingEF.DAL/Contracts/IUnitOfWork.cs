using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUsingEF.DAL.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IDatabaseTransaction BeginTrainsaction();
        IDbCommand CreateCommand();
        void SaveChanges();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MyTimeclock.SharedKernal;
namespace MyTimeclock.SharedKernal.Interfaces
{
    public interface IRepository
    {
        Task<T> GetByIdAsync<T>( int id ) where T : BaseEntity;
        Task<T> FirstOrDefaultAsync<T>( Expression<Func<T, bool>> filter ) where T : BaseEntity;
        Task<List<T>> ListAsync<T>() where T : BaseEntity;
        Task<List<T>> ListAsync<T>( Expression<Func<T, bool>> filter ) where T : BaseEntity;        
        Task<T> AddAsync<T>( T entity ) where T : BaseEntity;
        Task UpdateAsync<T>( T entity ) where T : BaseEntity;
        Task DeleteAsync<T>( T entity ) where T : BaseEntity;
    }
}

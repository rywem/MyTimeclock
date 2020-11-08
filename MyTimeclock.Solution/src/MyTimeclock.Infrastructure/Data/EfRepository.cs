using MyTimeclock.SharedKernal;
using MyTimeclock.SharedKernal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyTimeclock.Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EfRepository( ApplicationDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync<T>( T entity ) where T : BaseEntity
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync<T>( T entity ) where T : BaseEntity
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> FirstOrDefaultAsync<T>( Expression<Func<T, bool>> filter ) where T : BaseEntity
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(filter);
        }

        public async Task<T> GetByIdAsync<T>( int id ) where T : BaseEntity
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<T>> ListAsync<T>() where T : BaseEntity
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<List<T>> ListAsync<T>( Expression<Func<T, bool>> filter ) where T : BaseEntity
        {
            return await _dbContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task UpdateAsync<T>( T entity ) where T : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}

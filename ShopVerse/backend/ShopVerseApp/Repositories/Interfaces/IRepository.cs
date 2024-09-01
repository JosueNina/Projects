using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopVerseApp.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetMany(Expression<Func<T, bool>>? predicate = null);
        public Task<T?> GetByIdAsync(int id);
        public Task<T> CreateAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task<bool> DeleteAsync(T entity);
    }
}
using DemoAppDotNet7.Data;
using DemoAppDotNet7.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using NuGet.Common;
using System.Linq.Expressions;

namespace DemoAppDotNet7.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        protected AppDbContext _dbContext;
        public MainRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(params string[] agers)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            if (agers.Length > 0)
            {
                foreach (var item in agers)
                {
                    query = query.Include(item);
                }
            }
            return await query.ToListAsync();
        }

        public async Task<T> FindOneAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(expression);
        }

        public async Task<bool> RemoveItemAsync(T item)
        {
            try
            {
                _dbContext.Set<T>().Remove(item); 
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

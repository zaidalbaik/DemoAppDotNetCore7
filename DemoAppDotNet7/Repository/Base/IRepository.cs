using Newtonsoft.Json.Linq;
using System.Linq.Expressions;

namespace DemoAppDotNet7.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindByIdAsync(int id);
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindAllAsync(params string[] agers);

        Task<T> FindOneAsync(Expression<Func<T, bool>> expression);

        Task<bool> RemoveItemAsync(T item);

        Task<bool> AddNewItem(T item);
    }
}

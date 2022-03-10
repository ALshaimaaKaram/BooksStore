using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public interface IModelRepository<T>
    {
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetByIdAsync(int Id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Remove(T entity);
    }
}

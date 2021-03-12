using PublicApi.Entities;
using PublicApi.Interfaces.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PublicApi.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<List<T>> ListAsync(ISpecification<T> spec);
        Task AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
    }
}

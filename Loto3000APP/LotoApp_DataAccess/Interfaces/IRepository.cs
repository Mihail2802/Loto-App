using Loto3000App_Domain.Models;

namespace LotoApp_DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteByIdAsync(int id);
        Task<T> GetbyIdAsync(int id);
        Task<List<T>> GetAllAsync();

    }
}

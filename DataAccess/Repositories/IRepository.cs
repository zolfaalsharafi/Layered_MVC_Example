using MVC_Example.DataAccessLayer.Models;

namespace MVC_Example.DataAccessLayer.Repositories
{
    public interface IRepository<TModel> where TModel : BaseEntity
    {
        Task CreateAsync(TModel entity);
        Task<List<TModel>> GetAll();
        Task<TModel> GetById(int id);
        Task RemoveAsync(TModel entity);
        Task UpdateAsync(TModel entity);
    }
}
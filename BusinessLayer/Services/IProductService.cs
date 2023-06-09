using MVC_Example.DataAccessLayer.Models;
using MVC_Example.Dtos;

namespace BusinessLayer.Services
{
    public interface IProductService : ICrudService<ProductDto> 
    {
        Task Purchase(Product product);
    }
}
using BusinessLayer.Services;
using MVC_Example.Dtos;

namespace MVC_Example.Controllers
{
    public class CategoriesController : BaseCrudController<CategoryDto>
    {
        public CategoriesController(ICrudService<CategoryDto> crudService) : base(crudService)
        {
        }
    }
}

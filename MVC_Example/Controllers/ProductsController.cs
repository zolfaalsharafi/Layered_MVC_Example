using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using MVC_Example.Dtos;

namespace MVC_Example.Controllers
{
    public class ProductsController : BaseCrudController<ProductDto>
    {
        public ProductsController(IProductService crudService) : base(crudService)
        {
        }
    }
}
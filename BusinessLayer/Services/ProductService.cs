using MVC_Example.BusinessLayer.Services;
using MVC_Example.DataAccessLayer.Models;
using MVC_Example.DataAccessLayer.Repositories;
using MVC_Example.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ProductService : BaseCrudService<ProductDto, Product>, IProductService
    {
        public ProductService(IRepository<Product> repo) : base(repo)
        {
        }

        public Task Purchase(Product product)
        {
            // do purchase logic

            return Task.CompletedTask;
        }
        protected override ProductDto MapToDto(Product model)
        {
            return new ProductDto
            {
                Id = model.Id,
                Name = model.Name,
                CategoryId = model.CategoryId,
                CreatedDate = model.CreatedDate,
                Description = model.Description,
                Price = model.Price,
            };
        }

        protected override List<ProductDto> MapToDtoList(List<Product> data)
        {
            return data.Select(t => new ProductDto
            {
                Id = t.Id,
                Name = t.Name,
                CategoryId = t.CategoryId,
                CreatedDate = t.CreatedDate,
                Description = t.Description,
                Price = t.Price,
            }).ToList();
        }

        protected override Product MapToModel(ProductDto dto)
        {
            return new Product
            {
                CategoryId = dto.CategoryId,
                Name = dto.Name,
                Description = dto.Description,
                Id = dto.Id,
                Price = dto.Price,
                CreatedDate = dto.CreatedDate
            };
        }
    }
}

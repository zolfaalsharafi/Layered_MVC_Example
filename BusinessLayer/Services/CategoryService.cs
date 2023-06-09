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
    public class CategoryService : BaseCrudService<CategoryDto, Category>
    {
        public CategoryService(IRepository<Category> repo) : base(repo)
        {
        }

        protected override CategoryDto MapToDto(Category model)
        {
            return new CategoryDto
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                CreatedDate = model.CreatedDate
            };
        }

        protected override List<CategoryDto> MapToDtoList(List<Category> data)
        {
            return data.Select(t => new CategoryDto
            {
                Id = t.Id,
                Name = t.Name,
                Description = t.Description,
                CreatedDate = t.CreatedDate
            }).ToList();
        }

        protected override Category MapToModel(CategoryDto dto)
        {
            return new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                CreatedDate = dto.CreatedDate,
                Description = dto.Description
            };
        }
    }
}

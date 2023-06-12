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
    public class CountryService : BaseCrudService<CountryDto, Country>
    {
        public CountryService(IRepository<Country> repo) : base(repo)
        {
        }

        protected override CountryDto MapToDto(Country model)
        {
            return new CountryDto
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        protected override List<CountryDto> MapToDtoList(List<Country> data)
        {
            return data.Select(t => new CountryDto
            {
                Id = t.Id,
                Name = t.Name

            }).ToList();
        }

        protected override Country MapToModel(CountryDto dto)
        {
            return new Country
            {
                Id = dto.Id,
                Name = dto.Name,
                
            };
        }
    }
}

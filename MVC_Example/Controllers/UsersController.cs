using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Example.Dtos;

namespace MVC_Example.Controllers
{
    public class UsersController : BaseCrudController<UserDto>
    {
        public UsersController(ICrudService<UserDto> crudService) : base(crudService)
        {
        }
    }
}

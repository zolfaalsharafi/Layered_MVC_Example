
using BusinessLayer.Services;
using MVC_Example.Dtos;


namespace MVC_Example.BusinessLayer.Services
{
    public interface IEmailService : ICrudService<UserDto>
    {
        Task SendEmail(string recipientEmail, string subject, string body);
    }


}

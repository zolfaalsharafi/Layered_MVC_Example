using MVC_Example.Dtos;

namespace BusinessLayer.Services
{
    public interface ICrudService<TDto> where TDto : BaseDto
    {
        Task CreateAsync(TDto userDto);
        Task DeleteAsync(TDto userDto);
        Task<List<TDto>> GetAsync();
        Task<TDto> GetAsync(int id);
        Task UpdateAsync(TDto userDto);
    }
}
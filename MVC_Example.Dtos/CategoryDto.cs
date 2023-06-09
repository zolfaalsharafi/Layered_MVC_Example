namespace MVC_Example.Dtos
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductDto>? Products { get; set; }
    }
}

using BusinessLayer.Services;
using Microsoft.EntityFrameworkCore;
using MVC_Example.DataAccessLayer.Data;
using MVC_Example.DataAccessLayer.Repositories;
using MVC_Example.Dtos;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVC_ExampleContext") ?? throw new InvalidOperationException("Connection string 'MVC_ExampleContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<ICrudService<UserDto>, UserService>();
builder.Services.AddScoped<ICrudService<CategoryDto>, CategoryService>();
builder.Services.AddScoped<ICrudService<CountryDto>, CountryService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

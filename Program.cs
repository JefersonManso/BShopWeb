using BShop.ProductApi.Context;
using AutoMapper;
using BShop.ProductApi.DTOs.Mappings;
using Microsoft.EntityFrameworkCore;
using BShop.ProductApi.Services;
using BShop.ProductApi.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Connection string do MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Adiciona DbContext com Pomelo + MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Configura o AutoMapper 
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Registra serviços
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();

// Add controllers
builder.Services.AddControllers();

// Configuração do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "BShop Product API",
        Version = "v1",
        Description = "API para gerenciamento de produtos e categorias do sistema BShop",
        Contact = new OpenApiContact
        {
            Name = "Jeferson",
            Email = "seuemail@dominio.com"
        }
    });
});

var app = builder.Build();

// Middleware do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "BShop Product API v1");
        c.RoutePrefix = string.Empty;
    });

}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

using BShop.ProductApi.Context;
using AutoMapper;
using BShop.ProductApi.DTOs.Mappings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Connection string do MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


// Adiciona DbContext com Pomelo + MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


// Configura o AutoMapper manualmente
var mapperConfig = new MapperConfiguration(cfg =>
                   {
                       cfg.AddProfile(new MappingProfile());
                   });

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

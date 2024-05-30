using Microsoft.EntityFrameworkCore;
using ProductManagementBusiness.Services;
using ProductManagementDomain.Infrastructure;
using ProductManagementDomain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionStr = builder.Configuration.GetConnectionString("sqlcon");
builder.Services.AddDbContext<ProductDbContext>(options=>options.UseSqlServer(connectionStr));
builder.Services.AddControllers();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

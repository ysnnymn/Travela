using Travela.BusinessLayer.Abstract;
using Travela.BusinessLayer.Concrete;
using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Concrete;
using Travela.DataAccessLayer.Context;

var builder = WebApplication.CreateBuilder(args);

#region SERVICES

// DB Context
builder.Services.AddDbContext<TravelaContext>();

// Dependency Injection
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();
builder.Services.AddScoped<IDestinationService, DestinationManager>();

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

var app = builder.Build();

#region MIDDLEWARE PIPELINE

// Swagger (sadece development)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS redirect
app.UseHttpsRedirection();

app.UseAuthorization();

// Controllers map
app.MapControllers();

#endregion

app.Run();
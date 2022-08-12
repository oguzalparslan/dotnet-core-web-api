using Microsoft.EntityFrameworkCore;
using myApp.Core.Repositories;
using myApp.Core.Services;
using myApp.Core.UnitOfWork;
using myApp.Repository;
using myApp.Repository.UnitOfWork;
using myApp.Service.Mapping;
using myApp.Service.Service;
using AutoMapper;
using myApp.Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

builder.Services.AddAutoMapper(typeof(MapProfile));


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseInMemoryDatabase("SqlConn");
});



var app = builder.Build(); //Throw System.ArgumentException

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

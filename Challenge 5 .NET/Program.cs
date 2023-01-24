using AutoMapper;
using Challenge_5_.NET.Data;
using Challenge_5_.NET.Data.Ef_Core;
using Challenge_5_.NET.Profiles;
using Challenge_5_.NET.Service;
using Challenge_5_.NET.Service.Handler;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseMySql(builder.Configuration.GetConnectionString("filmeDb"), new MySqlServerVersion(new Version(8,0))));

builder.Services.AddTransient<IVideoDao, VideoDaoComEfCore>();
builder.Services.AddTransient<IAdminService, DefaultAdminService>();
builder.Services.AddTransient<ICategoriaDao, CategoriaDaoComEfCore>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Restaurant.API.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<RestaurantDbContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantDBConnection")), ServiceLifetime.Singleton);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

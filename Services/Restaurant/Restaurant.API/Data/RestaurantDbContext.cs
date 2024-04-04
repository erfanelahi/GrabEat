using Microsoft.EntityFrameworkCore;
using Restaurant.API.Entities;
using System;

namespace Restaurant.API.Data
{
    internal sealed class RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : DbContext(options)
    {
        public DbSet<Entities.Restaurant> Restaurants { get; init; }
        public DbSet<RestaurantType> RestaurantTypes { get; init; }
        public DbSet<Food> Foods { get; init; }
        public DbSet<FoodType> FoodTypes { get; init; }
    }
}
    
using Restaurant.API.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    internal record Food: EntityBase
    {
        [Key]
        public required int Id { get; init; }
        public required string Name { get; init; }
        public required double Price { get; init; }
        public required virtual FoodType Type { get; init; }

        public string? Description { get; init; }
        public string? ImageUrl { get; init; }
    }
}
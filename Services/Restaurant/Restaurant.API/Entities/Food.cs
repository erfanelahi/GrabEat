using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    public record Food
    {
        [Key]
        public required int Id { get; init; }
        public required string Name { get; init; }
        public required double Price { get; init; }
        public required List<FoodType> Types { get; init; }

        public string? Description { get; init; }
        public string? ImageUrl { get; init; }
    }
}
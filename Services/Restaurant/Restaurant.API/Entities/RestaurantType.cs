using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    public record RestaurantType
    {
        [Key]
        public required int Id { get; init; }
        public required string Name { get; init; }
    }
}
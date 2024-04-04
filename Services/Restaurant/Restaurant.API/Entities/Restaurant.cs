using Restaurant.API.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    internal record Restaurant: EntityBase
    {
        [Key]
        public required int Id { get; init; } 
        public required string Name { get; init; }
        public required string Address { get; init; }
        public required virtual ICollection<RestaurantType> Types { get; init; }
        public required virtual ICollection<Food> Foods { get; init; }

        public string? Description { get; init; }
        public string? ImageUrl { get; init; }
    }
}

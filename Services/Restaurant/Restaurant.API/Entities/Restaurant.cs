using Restaurant.API.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    internal record Restaurant: EntityBase
    {
        public Restaurant()
        {
            RestaurantTypes = new HashSet<RestaurantType>();
            Foods = new HashSet<Food>();
        }

        [Key]
        public required int Id { get; init; } 
        public required string Name { get; init; }
        public required string Address { get; init; }
        public required virtual ICollection<RestaurantType> RestaurantTypes { get; init; }
        public required virtual ICollection<Food> Foods { get; init; }

        public string? Description { get; init; }
        public string? ImageUrl { get; init; }
    }
}

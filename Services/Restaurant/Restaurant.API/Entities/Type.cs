using Restaurant.API.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    internal record Type: EntityBase
    {
        [Key]
        public required int Id { get; init; }
        public required string Name { get; init; }
        public required virtual ICollection<RestaurantType> RestaurantTypes { get; init; } = new HashSet<RestaurantType>();
    }
}
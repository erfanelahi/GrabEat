using Restaurant.API.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    internal sealed record RestaurantType: EntityBase
    {
        [Key]
        public required int Id { get; init; }
        public required string Name { get; init; }
    }
}
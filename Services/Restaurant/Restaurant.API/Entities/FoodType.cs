using Restaurant.API.Entities.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.API.Entities
{
    internal sealed record FoodType: EntityBase
    {
        [Key]
        public required int Id { get; init; }
        public required string Name { get; init; }
    }
}
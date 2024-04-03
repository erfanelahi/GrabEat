using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Restaurant.API.Entities
{
    public record Restaurant
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required int Id { get; init; } 
        public required string Name { get; init; }
        public required string Address { get; init; }
        public required List<RestaurantType> Types { get; init; }
        public required List<Food> Foods { get; init; }

        public string? Description { get; init; }
        public string? ImageUrl { get; init; }
    }
}

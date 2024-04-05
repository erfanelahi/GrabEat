namespace Restaurant.API.Entities
{
    internal record RestaurantType
    {
        public required int Id { get; init; }
        public required virtual Restaurant Restaurant { get; init; }
        public required virtual Type Type { get; init; }
    }
}

namespace Restaurant.API.Entities.Common
{
    internal abstract record EntityBase
    {
        public DateTime CreatedDate { get; init; }
    }
}

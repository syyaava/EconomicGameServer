namespace Core.market
{
    public class LotDto
    {
        public string Id { get; }
        public float Price { get; init; }
        public int Count { get; init; }
        public Item Item { get; init; }
    }
}
namespace Core.market
{
    public class Lot
    {
        public string Id { get; }
        public float Price { get; init; }
        public int Count { get; init;  }
        public Item Item { get; init; }

        public Lot(Item item, float price, int count = 1)
        {
            Id = Guid.NewGuid().ToString();
            Price = price;
            Count = count;
            Item = item;
        }
    }
}
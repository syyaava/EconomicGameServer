namespace Core.market
{
    public class Lot
    {
        public string Id { get; }
        public float Price { get; init; }
        public int Count { get; init;  }
        public Item Item { get; init; }

        public Lot(Item item, float price, string id = "", int count = 1)
        {
            if(string.IsNullOrEmpty(id))
                Id = Guid.NewGuid().ToString();
            else
                Id = id;
            Price = price;
            Count = count;
            Item = item;
        }
    }
}
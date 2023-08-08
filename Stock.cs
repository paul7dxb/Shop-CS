namespace AwesomeShop
{
    class Stock
    {
        public Item Item { get; }
        public int Quantity{ get; set; }
        public Stock(Item item, int quantity)
        {
            Item = new Item(item.Name, item.Price);
            Quantity = quantity;
        }

    }
}
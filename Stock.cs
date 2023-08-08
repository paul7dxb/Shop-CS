namespace AwesomeShop
{
    class Stock
    {
        public int Item { get; }
        public int Quantity{ get; set; }
        public Stock(int item)
        {
            Item = item;
            Quantity = 0;
        }


    }
}
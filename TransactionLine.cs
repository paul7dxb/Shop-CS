namespace AwesomeShop
{


    class TransactionLine
    {
        public Stock Stock { get; }
        public DateTime DateTime { get; }
        public Decimal TotalPrice { get; }
        public TransactionLine(Stock stock, DateTime dateTime)
        {
            Stock = new Stock(new Item(stock.Item.Name, stock.Item.Price), stock.Quantity);
            DateTime = dateTime;
            TotalPrice = stock.Item.Price * stock.Quantity;
        }
        public string PrintBasketLine()
        {
            return $"Item: {Stock.Item.Name} : {Stock.Quantity} @ {Stock.Item.Price} = {TotalPrice} ";
        }
    }


}

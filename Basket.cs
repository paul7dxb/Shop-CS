namespace AwesomeShop
{
    class Basket
    {

        public List<Stock> Inventory { get;}
        public decimal TotalPrice { get; set; }

        public Basket()
        {
            Inventory = new List<Stock>();
            TotalPrice = 0;
        }
        public void ShowBasket(string customer)
        {
            string basketString = "";
            if (Inventory.Count == 0){
                basketString = "No items in basket ";
            }
            foreach (Stock stock in Inventory)
            {
                basketString += $"Item: {stock.Item.Name}\tQuanity: {stock.Quantity}\n";
            }
            CoolConsole.PrintBoard($"Basket for {customer}:", basketString );
        }
    }


}
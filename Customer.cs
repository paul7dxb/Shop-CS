namespace AwesomeShop
{
    class Customer
    {
        public string Name { get; }
        public Warehouse Warehouse { get; }
        public Basket Basket { get; }

        public Customer(string name, Warehouse warehouse)
        {
            Name = name;
            Warehouse = warehouse;
            Basket = new Basket();
        }

        public void AddToBasket(Item item, int quantity)
        {
            if (Warehouse.StockAvailable(item, quantity))
            {

                Basket.Inventory.Add(new Stock(item, quantity));
                Warehouse.ReduceStock(item, quantity);
            }
            else
            {
                CoolConsole.NoBueno("Can't add to basket! Not enough stock or it doesn't exist!");
            }

        }

        public void ShowBasket(){
            Basket.ShowBasket(Name);
        }



    }
}
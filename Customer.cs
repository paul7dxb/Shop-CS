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

        public void AddToBasket(string itemName, int quantity)
        {
            if (Warehouse.StockAvailable(itemName, quantity))
            {

                Basket.Inventory.Add(new Stock(new Item(itemName, 0.3m), quantity));
                Warehouse.ReduceStock(itemName, quantity);
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
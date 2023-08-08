namespace AwesomeShop
{
    class Warehouse
    {
        public Manager Manager { get; }
        public List<Stock> Inventory { get; }

        public Warehouse()
        {
            Manager = new Manager("Megan");
            Inventory = new List<Stock>();
        }

        public void AddItem(Item item, int quantity)
        {

            bool itemInWarehouse = false;

            foreach (Stock stock in Inventory)
            {
                if (stock.Item.Name == item.Name)
                {
                    itemInWarehouse = true;
                    stock.Quantity += quantity;
                }
            }

            if (!itemInWarehouse)
            {
                Inventory.Add(new Stock(item, quantity));
            }

        }

        public bool StockAvailable(Item item, int quantity)
        {
            var invIndex = Inventory.FindIndex(stock => stock.Item.Name == item.Name);

            if (invIndex == -1) return false; //Item not found
            if (Inventory[invIndex].Quantity < quantity) return false; //Not enough stock

            return true;
        }

        public void ReduceStock(Item item, int quantity)
        {
            var invIndex = Inventory.FindIndex(stock => stock.Item.Name == item.Name);
            Inventory[invIndex].Quantity -= quantity;
        }

        public void PrintAllStock()
        {
            string stockString = "";
            foreach (Stock stock in Inventory)
            {
                stockString += $"Item: {stock.Item.Name}\tQuantity: {stock.Quantity}\n";
            }
            CoolConsole.PrintBoard("Current Stock in Warehouse:", stockString);

        }

        public decimal GetItemPrice(string itemName){
            var invIndex = Inventory.FindIndex(stock => stock.Item.Name == itemName);

            return Inventory[invIndex].Item.Price;
        }

    }
}
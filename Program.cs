namespace AwesomeShop
{

    public class Program
    {
        static void Main(string[] args)
        {
            var morningRolls = new Stock( new Item("Morning Roll", (decimal)0.65),3);
            var sugaredDonuts = new Stock( new Item("Sugared Donut", (decimal)0.65),3);
            var sausageRolls = new Stock( new Item("Sausage Roll", (decimal)0.65),3);
            List<Stock> intialStock = new List<Stock>{morningRolls, sugaredDonuts, sausageRolls, sausageRolls};


            var paulsShop = new Shop("Paul's Little Bakery");
            paulsShop.AddInitialStock(intialStock);
            paulsShop.CreateTestCustomers();

            paulsShop.PrintCustomerNames();

            var cookieMonster = new Customer("Cookie Monster", paulsShop.Warehouse);
            paulsShop.AddCustomer(cookieMonster);

            paulsShop.Warehouse.AddItem(new Item("Morning Roll", (decimal)0.65), 3);
            paulsShop.Warehouse.AddItem(new Item("Shortbread", (decimal)1.50), 3);

            // Console.WriteLine(paulsShop.GetCustomerNames());
            paulsShop.Warehouse.PrintAllStock();

            var cookies = new Item("Cookies", 0.8m);

            cookieMonster.AddToBasket(cookies, 3);
            cookieMonster.ShowBasket();


            paulsShop.Warehouse.AddItem(cookies, 1);
            cookieMonster.AddToBasket(cookies, 3);
            cookieMonster.ShowBasket();
            paulsShop.Warehouse.AddItem(cookies, 2);
            cookieMonster.AddToBasket(cookies, 3);
            cookieMonster.ShowBasket();
            paulsShop.Warehouse.PrintAllStock();








        }
    }
}
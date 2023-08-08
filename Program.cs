namespace AwesomeShop
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();

            var paulsShop = new Shop("Paul's Little Bakery");
            paulsShop.AddInitialStock();
            paulsShop.CreateTestCustomers();

            paulsShop.PrintCustomerNames();

            var cookieMonster = new Customer("Cookie Monster", paulsShop.Warehouse);
            paulsShop.AddCustomer(cookieMonster);

            paulsShop.Warehouse.AddItem(new Item("Morning Roll", (decimal)0.65), 3);
            paulsShop.Warehouse.AddItem(new Item("Shortbread", (decimal)1.50), 3);

            // Console.WriteLine(paulsShop.GetCustomerNames());
            paulsShop.Warehouse.PrintAllStock();

            cookieMonster.AddToBasket("Cookies", 3);
            cookieMonster.ShowBasket();


            paulsShop.Warehouse.AddItem(new Item("Cookies", (decimal)1.00), 1);
            cookieMonster.AddToBasket("Cookies", 3);
            cookieMonster.ShowBasket();
            paulsShop.Warehouse.AddItem(new Item("Cookies", (decimal)1.00), 2);
            cookieMonster.AddToBasket("Cookies", 3);
            cookieMonster.ShowBasket();







        }
    }
}
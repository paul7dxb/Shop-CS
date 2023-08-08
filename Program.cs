namespace AwesomeShop
{

    public class Program
    {
        static void Main(string[] args)
        {
            var paulsShop = new Shop("Paul's Little Bakery");

            Console.WriteLine(paulsShop.Name);
            Console.WriteLine(paulsShop.Warehouse.Manager.Name);

            var firstCustomer = new Customer("Alfred", paulsShop.Warehouse);
            paulsShop.AddCustomer(firstCustomer);

            Console.WriteLine(paulsShop.GetCustomerNames());

        }

    }
}
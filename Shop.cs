namespace AwesomeShop
{
    class Shop
    {
        public Warehouse Warehouse { get; set; }
        public Accounting Accounting { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }

        public Shop(string name)
        {
            Name = name;
            Warehouse = new Warehouse();
            Accounting = new Accounting();
            Customers = new List<Customer>();
        }


        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void PrintCustomerNames()
        {

            string custumerString = "";
            foreach (Customer customer in Customers)
            {
                custumerString += $"{customer.Name}\n";
            }

            CoolConsole.PrintBoard("Customer's at {Name}:", custumerString);


        }


        public void AddInitialStock(List<Stock> stocks)
        {
            foreach (Stock stock in stocks){
                Warehouse.AddItem(stock.Item, stock.Quantity);
            }

        }

        public void CreateTestCustomers()
        {
            AddCustomer(new Customer("Alfred", this));
            AddCustomer(new Customer("Batman", this));
            AddCustomer(new Customer("Catwoman", this));
            AddCustomer(new Customer("Dave", this));
        }

    }
}
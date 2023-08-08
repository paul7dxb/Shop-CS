namespace AwesomeShop
{
    class Shop
    {
        public Warehouse Warehouse { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }

        public Shop(string name)
        {
            Name = name;
            Warehouse = new Warehouse();
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


        public void AddInitialStock()
        {
            Warehouse.AddItem(new Item("Morning Roll", (decimal)0.65), 3);
            Warehouse.AddItem(new Item("Sugared Donut", (decimal)0.48), 12);
            Warehouse.AddItem(new Item("Sausage Roll", (decimal)1.35), 2);

        }

        public void CreateTestCustomers()
        {
            AddCustomer(new Customer("Alfred", Warehouse));
            AddCustomer(new Customer("Batman", Warehouse));
            AddCustomer(new Customer("Catwoman", Warehouse));
            AddCustomer(new Customer("Dave", Warehouse));
        }

    }
}
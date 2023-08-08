namespace AwesomeShop{
    class Shop{
        public Warehouse Warehouse {get;set;}
        public string Name { get; set;}
        public List<Customer> Customers { get; set;}

        public Shop(string name){
            Name = name;
            Warehouse = new Warehouse();
            Customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer){
            Customers.Add(customer);
        }

        public string GetCustomerNames(){
            string custumerString = $"\nCustomer's at {Name}:\n";

            foreach(Customer customer in Customers){
                custumerString += $"{customer.Name}\n";
            }

            return custumerString;
        }

    }
}
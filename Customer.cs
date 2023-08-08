namespace AwesomeShop{
    class Customer{
        public string Name { get; set;}
        public Warehouse Warehouse { get; set;}
        public Basket Basket { get; set;}

        public Customer(string name, Warehouse warehouse){
            Name = name;
            Warehouse = warehouse;
            Basket = new Basket();
        }
        
    }
}
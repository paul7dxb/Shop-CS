namespace AwesomeShop{
    class Warehouse{
        public Manager Manager { get; set;}
        public List<Stock> Inventory { get; set;}

        public Warehouse(){
            Manager = new Manager("Megan");
            Inventory = new List<Stock>();
        }
        
    }
}
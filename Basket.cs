namespace AwesomeShop{
    class Basket{

        public List<Stock> Inventory;
        public decimal TotalPrice { get; set; }

        public Basket(){
            Inventory = new List<Stock>();
            TotalPrice = 0;
        }
        
    }
}
namespace AwesomeShop
{


    class Receipt
    {
        string CustomerName { get; }
        public DateTime DateTime { get; }
        public Decimal TotalPrice { get; }


        public Receipt(Basket basket, string customerName, DateTime dateTime)
        {
            CustomerName = customerName;
            TotalPrice = basket.TotalPrice;
            DateTime = dateTime;
            
        }        
        public void PrintReceipt()
        {
            string receiptLine =  $"Name: {CustomerName}\nDate: {DateTime.ToShortDateString}\nTotal: {TotalPrice}";
            // return $"Item: {Stock.Item.Name} : {Stock.Quantity} @ {Stock.Item.Price} = {TotalPrice} ";
            Console.WriteLine(receiptLine);
        }
    }
}
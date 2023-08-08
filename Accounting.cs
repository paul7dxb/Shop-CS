namespace AwesomeShop
{
    class Accounting
    {
        public List<Receipt> TransactionHistory { get; }

        public Accounting()
        {
            TransactionHistory = new List<Receipt>();
        }

        public void MakePurchase(Basket basket, string customerName)
        {
            TransactionHistory.Add(new Receipt(basket, customerName, DateTime.Now));
        }

        public void PrintTransactions(){
            Console.WriteLine("Receipts");
            foreach (Receipt receipt in TransactionHistory){
                receipt.PrintReceipt();
            }
        }

    }
}

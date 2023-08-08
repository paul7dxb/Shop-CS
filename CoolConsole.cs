namespace AwesomeShop
{
    class CoolConsole
    {
        public static void PrintBoard(string title, string content){
            Console.WriteLine($"*********************************************");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(title);
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine(content);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
        }

        public static void NoBueno(string message){
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{message}");
            Console.ResetColor();
            Console.WriteLine("\n");
        }

        public static void ShopInfo(string message){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{message}");
            Console.ResetColor();
            Console.WriteLine("\n");
        }
    }
}
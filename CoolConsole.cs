namespace AwesomeShop
{
    class CoolConsole
    {
        public static void PrintBoard(string title, string content){
            Console.WriteLine($"*********************************************");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(title);
            Console.ResetColor();
            Console.WriteLine(content);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
        }

        public static void NoBueno(string message){
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{message}\n");
            Console.ResetColor();
        }
    }
}
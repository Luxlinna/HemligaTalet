using System;

namespace HemligaTaletDel1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomerare = new Random(); 
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            for (int i = 0; i < 10; i++)
            {
                int slump_tal = randomerare.Next(1, 101);
                Console.WriteLine(slump_tal);   
            }
            Console.ReadLine();
        }
    }
}

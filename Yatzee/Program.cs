using System;

namespace Yatzee
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Yatzee.");
            Console.WriteLine("Press Enter to begin.");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
            Console.Clear();
            var game = new Game();
            game.Play();
        }
    }
}

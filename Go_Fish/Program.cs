using System;

namespace Go_Fish
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("Go Fish");

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
}

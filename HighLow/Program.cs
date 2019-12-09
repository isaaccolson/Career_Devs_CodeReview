using System;

namespace HighLow
{
    class MainClass
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("High Low");
           

                var game = new Game();
                game.Play();

            
        }
    }
}

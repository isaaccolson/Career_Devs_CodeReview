using System;
namespace Yatzee
{
    public class Game
    {
        Die[] dice = new Die[5];
        int numRerolls = 2;

        public Game()
        {
            int numSidesDie = 6;

            for (var i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die(numSidesDie);
            }
        }

        public void Play()
        {

            while (true)
            {

                int[] dieResults = new int[dice.Length];

                for (var i = 0; i < dice.Length; i++)
                {
                    dieResults[i] = dice[i].Roll();

                }

                DisplayDice(dieResults);


                for (var j = 0; j < numRerolls; j++)
                {
                    Console.WriteLine("Which dice do you want to re-roll?");
                    string input = Console.ReadLine();
                    foreach (char num in input)
                    {
                        dieResults[(int)Char.GetNumericValue(num) - 1] = dice[(int)Char.GetNumericValue(num) - 1].Roll();
                    }

                    DisplayDice(dieResults);
                }

                if (IsYatzee(dieResults))
                {
                    Console.WriteLine("YATZEE!");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Press Enter to Try Again.");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }
        }

        void DisplayDice(int[] _results)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (int result in _results)
            {
                Console.WriteLine(result);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        bool IsYatzee(int[] _results)
        {
            var num = _results[0];

            var yatzee = true;

            foreach (int result in _results)
            {
                if (result != num)
                {
                    yatzee = false;
                    break;
                }
            }

            return yatzee;
        }
    }

}

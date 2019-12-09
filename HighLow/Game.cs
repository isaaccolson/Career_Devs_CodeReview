using System;
namespace HighLow
{
    public class Game
    {
        GetRandomCard rcg = new GetRandomCard();
        Card lastActiveCard;
        public Game()
        {
            lastActiveCard = rcg.GenerateCard();
        }

        public void Play() {
            var score = 0;
            while (true) {

                var activeCard = lastActiveCard;
                var drawnCard = rcg.GenerateCard();
                var guess = "";
                var answer = "";
                

                while (true) {
                    if (activeCard.name == drawnCard.name)
                    {
                        drawnCard = rcg.GenerateCard();
                    }
                    else {
                        break;
                    }
                }

                if (activeCard.value > drawnCard.value)
                {
                    answer = "l";
                }
                else if (activeCard.value < drawnCard.value)
                {
                    answer = "h";
                }
                else {
                    answer = "p";
                }



                Console.WriteLine("\nActive Card is " + activeCard.name);

                Console.WriteLine("Please enter h for high or l for low.");
                guess = Console.ReadLine();

                Console.WriteLine("Drawn Card is " + drawnCard.name);

                if (answer == "p")
                {
                    Console.WriteLine("Values are the same. Pass.");
                    lastActiveCard = drawnCard;
                }
                else {

                    if (answer == guess)
                    {
                        score++;
                        Console.WriteLine("Correct. Score: " + score);
                        lastActiveCard = drawnCard;
                        
                    }
                    else {
                        score = 0;
                        lastActiveCard = rcg.GenerateCard();
                        var count = 0;
                        while (count < 1000) {
                            Console.WriteLine("You guessed wrong. Score: " + score);
                            count++;
                        }
                        
                    }

                }

               


            }
        }
    }
}

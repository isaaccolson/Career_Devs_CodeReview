using System;
namespace Go_Fish
{
    public static class Turn
    {
        public static void TakeTurn(Player _player, Player enemy, Deck _deck) {

            Console.Clear();

            Card cardChosen;

            Console.WriteLine("\n"+_player.name + ": Press Enter To Start Turn");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }

            while (true)
            {
                Console.Clear();

                if (_player.hand.cards.Count <= 0)
                {
                    for (var i = 0; i < 3; i++)
                    {
                        _player.hand.AddCard(_deck.DealSingleCard(), _player);
                    }

                    if (_player.hand.cards.Count <= 0) {
                        break;
                    }

                    Console.WriteLine(_player.name + " drew more cards.");
                }



                

                if (!_player.isAi)
                {

                    _player.DisplayHand();
                    Console.WriteLine("\nYou have " + _player.score + " points. And " + enemy.name + " has " + enemy.score + " points.");

                    //Display number of cards enemy has

                    Console.WriteLine(enemy.name + ": has " + enemy.hand.CardsInHand() + " cards");

                    Console.WriteLine("\nChoose a card to guess: from 1 - number of cards in your hand.");

                    var index = Console.ReadLine();

                    cardChosen = _player.hand.cards[Convert.ToInt32(index) - 1];

                }
                else {
                    cardChosen = _player.hand.GetRandomCard();
                    Console.WriteLine("Ai " + _player.name);
                }


                Console.WriteLine("Do you have a " + cardChosen.type + "?");

                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }

                if (enemy.hand.NumberExists(cardChosen))
                {

                    Console.WriteLine("Yes.");
                    _player.score++;
                    _player.hand.RemoveCard(cardChosen);

                    if (enemy.hand.cards.Count <= 0)
                    {
                        for (var i = 0; i < 3; i++)
                        {
                            enemy.hand.AddCard(_deck.DealSingleCard(), _player);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Go Fish");
                    var newCard = _deck.DealSingleCard();
                    if (_player.isAi)
                    {
                        Console.WriteLine("Drew a card and has " + _player.hand.CardsInHand() + " cards in hand.");
                    }
                    else {
                        Console.WriteLine("Drew a " + newCard.name);
                    }
                    
                    _player.hand.AddCard(newCard,_player);
                    Console.WriteLine("Press Enter To Start Turn Next Player's Turn");
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                    }
                    break;
                }

                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }

            }

        }
    }
}

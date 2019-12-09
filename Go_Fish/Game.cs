using System;
namespace Go_Fish
{
    public class Game
    {
        bool singlePlayer;
        Deck deck;
        int numOfSuits = 4;
        int numOfValues = 13;
        int numOfJokers = 0;

        int numberOfPlayers = 2;
        int startingHandCount = 5;

        Player player1 = new Player(false, "Player 1");
        Player player2;

        public Game()
        {
            deck = new Deck(numOfSuits,numOfValues,numOfJokers);//standard deck of cards
        }

        public void Play() {

            GetNumberOfPlayers();

            CreatePlayers();

            deck.Shuffle();

            DealHand(player1);
            DealHand(player2);

            while (deck.cards.Count > 0) {
                Turn.TakeTurn(player1, player2, deck);
                Turn.TakeTurn(player2, player1, deck);
            }

            Console.WriteLine("Game Over\n" + player1.name + " has " + player1.score + " points.\n" + player2.name + " has " + player2.score + " points.\n");
        }

        void GetNumberOfPlayers()
        {
            Console.WriteLine("Press 1 for single player; 2 for a 2 player game.");

            var numPlayers = Console.ReadLine();

            if (numPlayers == "2")
            {
                singlePlayer = false;
                Console.WriteLine("Two Player Game");
            }
            else
            {
                singlePlayer = true;
                Console.WriteLine("Single Player Game");
            }
        }

        void DealHand(Player _player) {

            
                for (var j = 0; j < startingHandCount; j++) {
                    _player.hand.AddCard(deck.DealSingleCard(),_player);
                }
            
         
        }

        void CreatePlayers() {
            player2 = new Player(singlePlayer, "Player 2");
        }
    }
}

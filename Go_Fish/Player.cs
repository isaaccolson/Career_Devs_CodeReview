using System;
namespace Go_Fish
{
    public class Player
    {
        public bool isAi;
        public Hand hand;
        public string name;
        public int score = 0;

        public Player(bool _isAi, string _name)
        {
            isAi = _isAi;
            name = _name;
            hand = new Hand();
        }

        public void DisplayHand() {

            foreach (Card card in hand.cards)
            {
                if (card != null) {

                Console.WriteLine(card.name);
                }
            }
        }



    }
}

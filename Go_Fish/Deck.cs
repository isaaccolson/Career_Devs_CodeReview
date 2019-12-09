using System;
using System.Collections.Generic;
using System.Linq;

namespace Go_Fish
{


    public class Deck
    {
        Random random = new Random();

        public List<Card> cards = new List<Card>();

        public List<Card> discardPile = new List<Card>();



        public Deck(List<Card> _cards)
        {//simply pass collection of cards

            cards = _cards;

        }

        public Deck(int suits, int values, int numOfJkrs)
        {
            for (var i = 0; i < suits; i++)
            {
                for (var j = 1; j <= values; j++)
                {
                    this.cards.Add(new Card(i, j));
                }
            }
            for (int jkr = 0; jkr < numOfJkrs; jkr++)
            {
                this.cards.Add(new Card(-1, 0));
            }
        }

        public void Shuffle()
        {
            for (int index = this.cards.Count - 1; index > 0; index--)
            {
                int position = random.Next(index + 1);
                Card temp = this.cards[index];
                this.cards[index] = this.cards[position];
                this.cards[position] = temp;
            }
        }

        public Card DealSingleCard() {

            if (cards.Count > 0)
            {
                var deltCard = cards[0];
                cards.RemoveAt(0);
                return deltCard;
            }
            else {
                Console.WriteLine("Empty Deck");
                return null;
            }
           
        }

        public Deck Deal(int _numCards)
        {//need to know if resuffle the discard pile

            List<Card> hand = new List<Card>();

            for (var i = 0; i < _numCards; i++)
            {

                if (cards.Count <= 0)
                {

                    cards = discardPile.ToList();//using Linq
                    discardPile.Clear();

                    Console.WriteLine("Resuffled discard Pile.");

                    this.Shuffle();
                }

                hand.Add(cards[0]);
                cards.RemoveAt(0);

            }

            return new Deck(hand);
        }
    }

}

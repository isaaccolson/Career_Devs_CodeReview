using System;
using System.Collections.Generic;

namespace Go_Fish
{
    public class Hand
    {
        public List<Card> cards = new List<Card>();
        Random random = new Random();

        public Hand()
        {
           

        }

 

        public bool NumberExists(Card _card) {//removes card as well only for go fish

            if(_card == null) {
                return false;
            }

            foreach (Card card in cards) {

                if (card.value == _card.value && card != _card) {

                    cards.Remove(card);

                    return true;
                }
            }
            return false;
        }

        public void AddCard(Card _card,Player player) {

            if (NumberExists(_card))
            {
                player.score++;
                Console.WriteLine(player.name + " matched 2 " + _card.type + "s");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                }
            }
            else {
                cards.Add(_card);
            }
            
        }

        public void RemoveCard(Card _card)
        {
            cards.Remove(_card);
        }

        public int CardsInHand() {

            return cards.Count;

        }

        public Card GetRandomCard() {

            var randomIndex = random.Next(0, cards.Count);

        
            return cards[randomIndex];
        }
    }
}

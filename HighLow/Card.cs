using System;
using System.Collections.Generic;

namespace HighLow
{
    public class Card
    {
        public string name { get; private set; }
        string suit;
        string type;
        public int value { get; private set; }

        private readonly Dictionary<int, string> FACE_MAP = new Dictionary<int, string>() {
        {1, "Ace"},
        {10, "10"},
        {11, "Jack"},
        {12, "Queen"},
        {13, "King"}
    };
        private readonly Dictionary<int, string> SUIT_MAP = new Dictionary<int, string>() {
        {0, "Hearts"},
        {1, "Diamonds"},
        {2, "Clubs"},
        {3, "Spades"}
    };

        public Card(int _suit, int _value)
        {
            suit = SUIT_MAP[_suit];
            value = _value;
            type = cardNameDisplay();
            name = type + " of " + suit;

        }

        public string cardNameDisplay() {

            if (FACE_MAP.ContainsKey(this.value))
            {
                return this.FACE_MAP[this.value];
            }
            return this.value.ToString();
        }
    }
    }

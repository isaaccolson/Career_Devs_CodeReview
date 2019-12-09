using System;
namespace HighLow
{
    public class GetRandomCard
    {
        Random random = new Random();

        public GetRandomCard()
        {
            
        }

        public Card GenerateCard() {

            var suit = random.Next(0, 4);
            var value = random.Next(1, 14);

            return new Card(suit, value);
        }
    }
}

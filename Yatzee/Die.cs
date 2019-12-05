using System;
namespace Yatzee
{
    public class Die
    {
        int numberOfSides = 6;
        readonly Random rnd = new Random();

        public Die()
        {

        }

        public Die(int _numberOfSides)
        {
            numberOfSides = _numberOfSides;
        }

        public int Roll()
        {

            return rnd.Next(1, numberOfSides + 1);
        }
    }
}

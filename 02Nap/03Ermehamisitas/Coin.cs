using System;

namespace _03Ermehamisitas
{
    public class Coin
    {
        Random random = new Random();

        public int Collect()
        {
          return random.Next(0, 2);
        }
    }
}
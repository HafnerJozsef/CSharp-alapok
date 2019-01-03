using System;

namespace _03Ermehamisitas
{
    public class Coin
    {
        public Coin()
        {
            Console.WriteLine("Coin konstruktor");
        }
        Random random = new Random();

        //virtual kulcsszóval engedélyezem a hamisítást
        public virtual int Collect()
        {
            Console.Write("Coin.Collect()");
          return random.Next(0, 2);
        }
    }
}
using System;

namespace _03Ermehamisitas
{
    class Program
    {
        static void Main(string[] args)
        {
            var coin = new Coin();
            Console.WriteLine($"Az érmefeldobás eredménye: ");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{coin.Collect()},");
            }
            Console.ReadLine();           
        }
    }
}

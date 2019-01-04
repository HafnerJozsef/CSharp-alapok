using System;

namespace _03Ermehamisitas
{
    class Program
    {
        static void Main(string[] args)
        {
            var coin = new FakeCoin();

            DoCollects(coin);

            Console.ReadLine();
        }

        private static void DoCollects(Coin coin)
        {
            Console.WriteLine($"Az érmefeldobás eredménye: ");
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{coin.Collect()},");
            }
        }
    }
}

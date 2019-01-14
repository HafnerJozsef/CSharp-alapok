using System;
using System.Collections.Generic;

namespace _02IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in ShoppingList())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static IEnumerable<string> ShoppingList()
        {
            yield return "1 kg marhahús";
            yield return "só";
            yield return "1 kg alma";
            yield return "1 kg burgonya";

            //statikus fgv-ből statikus fgv-t hívhatok
            //ShoppingList();
            //Main(new string[] { });
            //InstanceFunction();

        }

        public void InstanceFunction()
        {
            //példányszintű fgv-ből híhatok példányszintűt
            InstanceFunction();
            //illetve statikust
            ShoppingList();
            Main(new string[] { });

        }
    }
}

using System;

namespace _01ConstructorFinalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Base();
            Console.WriteLine();

            //var m = new Middle();
            //Console.WriteLine();

            //var t = new Third();
            //Console.WriteLine();

            b = new Base("ez az alaposztály");
            Console.WriteLine();

            b = new Base("ez az alaposztály", "alap@alap.hu");
            Console.WriteLine();

            var m = new Middle("az a middle", "middlea@middle.hu");
            Console.WriteLine($"név: {m.Name}, email: {m.Email}");
            Console.WriteLine();


            var t = new Third("az a third", "third@third.hu");
            Console.WriteLine($"név: {t.Name}, email: {t.Email}");
            Console.WriteLine();

            //takarítás előkészítése

            b = null;
            m = null;
            t = null;

            //ki kell kény szeríteni a takarítást - nem általánosan használandó!!!!

            GC.Collect();


            Console.ReadLine();
        }
    }
}

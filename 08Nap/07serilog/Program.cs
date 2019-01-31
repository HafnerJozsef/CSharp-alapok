using System;

namespace _07serilog
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            while (!Console.KeyAvailable) //addig fut, amig nem nyomunk le egy billentyűt
            {
                var level = r.Next(100);
                //kisebb súlyú bejegyzésből többet szeretnénk, a minél súlyosabb, annál kevesebbet kevesebbet

                if (level < 50)
                { //legkisebb súlyú, delegsűrűbben előforduló (Debug)


                }
                if (level >= 50 && level < 70)
                {//info

                }
                if (level >= 70 && level < 85)
                {//Warning

                }
                if (level >= 85 && level < 95)
                {//Error

                }
                if (level >= 95)
                {//Fatal

                }
                Thread.Sleep(200);
            }
        }
    }
}

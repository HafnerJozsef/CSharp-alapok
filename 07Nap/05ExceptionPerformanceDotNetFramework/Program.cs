using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ExceptionPerformanceDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();



            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                { }
            }

            Console.WriteLine($"Eltelt idő: {sw.ElapsedTicks}");


            sw.Restart();
            for (int i = 0; i < 1000; i++)
            {
                //try
                //{
                //    throw new Exception();
                //}
                //catch (Exception)
                //{ }
            }

            sw.Stop();
            Console.WriteLine($"Eltelt idő: {sw.ElapsedTicks}");


            Console.ReadLine();
        }
    }
}

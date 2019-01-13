using System;
using System.Drawing;

namespace _03GarbageCollectorExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Console.KeyAvailable)
            {
                //var bitmap = new Bitmap(1280, 1024);
                using (var bitmap = new Bitmap(2048, 2048)) { }
            }
        }
    }
}

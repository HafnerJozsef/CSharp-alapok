using System;

namespace _02SikidomokTerulete
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);

            Console.WriteLine($"A négyzet területe: {square.Area()}");

            var circle = new Circle(radius: 5);
            Console.WriteLine($"A kör területe: {circle.Area()}");

            var triangle = new Triangle(trianglebase: 6, height: 4);
            Console.WriteLine($"A háromszög területe: {triangle.Area()}");

            //területek összeadása:
            var areasum = square.Area();
            areasum = areasum + circle.Area();
            //előző művelet rövidítve
            areasum += triangle.Area();

            //profibb munka (mi van, ha több száz síkidom területét kell összeadni):


            Console.WriteLine($"A területek összege: {areasum}");

            Console.ReadLine();
        }
    }
}

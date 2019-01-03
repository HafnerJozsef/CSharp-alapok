using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine($"A területek összege: {areasum}");

            //profibb munka (mi van, ha több száz síkidom területét kell összeadni):

            var planes = new List<IPlane>();
            planes.Add(square);
            planes.Add(triangle);
            planes.Add(circle);

            //var sum = 0;

            //foreach (var plane in planes)
            //{
            //    sum += plane.Area();
            //}

            //Console.WriteLine($"A területek összege: {sum}");

            //ciklus helyett Linq használata:
            //var sum = planes.Sum(x => x.Area());

            //Console.WriteLine($"A területek összege: {sum}");

            //még rövidebben:
            Console.WriteLine($"A területek összege: {planes.Sum(x => x.Area())}");

            Console.ReadLine();
        }
    }
}

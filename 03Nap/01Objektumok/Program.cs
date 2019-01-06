using System;

namespace _01Objektumok
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane1 = new Plane();
            var plane2 = new Plane();

            //azonosíthatóság: el tudjuk dönteni, hogy a két példány azonos-e?
            if (plane1==plane2)
            {
                Console.WriteLine("A két példány azonos");
            }
            else
            {
                Console.WriteLine("A két pédány nem azonos");
            }

            //állapot tárolása
            plane1.NrOfEdge = 3;
            plane2.NrOfEdge = 5;

            plane1.Name = "PLANE1";
            Console.WriteLine(plane1.Name);

            plane1.Show(1, 3);

            //érték szerinti átadás
            var ertek = 2;
            //referencia szerinti átadás

            var referencia = new ReferenciaTipus() { ertek = 3 };
            //tudunk értéktípust referencia szerint átadni
            var ertek2 = 4;

            Console.WriteLine($"ertek: {ertek}, referencia: {referencia.ertek}, ertek2: {ertek2}");

            //amikor az alapértelmezéstől eltér a paraméterátadás, ezt a hívó oldalon is jelezni kell (ref, out)
            int ertek3;
            plane1.Show(ertek, referencia, ref ertek2, out ertek3);

            //ezt már így is lehet definiálni:
            //plane1.Show(ertek, referencia, ref ertek2, out int ertek3);

            Console.WriteLine($"ertek: {ertek}, referencia: {referencia.ertek}, ertek2: {ertek2}, ertek3: {ertek3}");

            //az alapértelmezett értékekkel rendelkező paraméterek elhagyhatók

            plane1.Show();//FIGYELEM ez a paraméter nélküli fgv-t hívja
            plane1.Show(width : 9, name: "akármi");//alapértelmezett értéke miatt a többi paramétert ki lehet hagyni




            Console.ReadLine();

        }
    }
}

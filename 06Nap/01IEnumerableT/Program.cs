using System;

namespace _01IEnumerableT
{
    class Program
    {
        static void Main(string[] args)
        {
            var adat = new Adat(szam: 1, szoveg: "Marhahús");

            var adatok = new BejarhatoAdatok();

            adatok.Add(adat);
            adatok.Add(new Adat(szam: 1, szoveg: "Pirospaprika"));
            adatok.Add(new Adat(szam: 1, szoveg: "Burgonya"));
            adatok.Add(new Adat(szam: 1, szoveg: "Só"));
        }
    }
}

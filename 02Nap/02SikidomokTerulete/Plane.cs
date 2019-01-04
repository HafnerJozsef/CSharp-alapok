using System;

namespace _02SikidomokTerulete
{
    public abstract class Plane
    {
        //mivel  nincs általános síkidom területszámítás, ide nem tudunk érvényes implementációt adni
        //van viszont absztakt függvény (ez egyben virtual is)

            //absztakt fgv-t csak absztrakt osztályban lehet létrehozni
        public abstract double Area();
        


    }
}
using System;

namespace _02SikidomokTerulete
{
    //absztakt fgv-t csak absztrakt osztályban lehet létrehozni
    public abstract class Plane : IPlane
    {
        public string Name { get; set; }
        //mivel  nincs általános síkidom területszámítás, ide nem tudunk érvényes implementációt adni
        //van viszont absztakt függvény (ez egyben virtual is)

        public void Show()
        {
            //megjelenítést végző  fgv imolementációja
        }
    

        public void Hide()
        {
            //eltűntetés implementációja
        }


    public abstract double Area();
        


    }
}
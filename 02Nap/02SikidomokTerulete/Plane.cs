using System;

namespace _02SikidomokTerulete
{
    //absztakt fgv-t csak absztrakt osztályban lehet létrehozni
    public abstract class Plane : IPlane, IDisplayable
    {
        public string Name { get; set; }

        #region IDisplayable
        public int PosX { get; set; }
        public int PosY { get; set; }
        #endregion IDisplayable

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
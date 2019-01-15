using System;
using System.Collections.Generic;

namespace _01IEnumerableT
{
    public class BejarhatoAdatok
    {
        List<Adat> adatok = new List<Adat>();
        #region Adatok karbantartására szolgáló felület
        public void Add(Adat adat)
        {
            adatok.Add(adat);
        }

        public bool Remove(Adat adat)
        {
           return adatok.Remove(adat);
        }
        #endregion Adatok karbantartására szolgáló felület
    }
}
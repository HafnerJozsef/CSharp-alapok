using System;
using System.Collections.Generic;

namespace _01IEnumerableT
{
    public class BejarhatoAdatok<TAdat>
    {
        List<TAdat> adatok = new List<TAdat>();
        #region Adatok karbantartására szolgáló felület
        public void Add(TAdat adat)
        {
            adatok.Add(adat);
        }

        public bool Remove(TAdat adat)
        {
           return adatok.Remove(adat);
        }
        #endregion Adatok karbantartására szolgáló felület
    }
}
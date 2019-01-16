using System;
using System.Collections;
using System.Collections.Generic;

namespace _01IEnumerableT
{
    public class BejarhatoAdatok<TAdat> : IEnumerable<TAdat>, IEnumerator<TAdat>
    {
        List<TAdat> adatok = new List<TAdat>();
        int position = -1;

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

        #region IEnumerable<TAdat> implementáció
        public IEnumerator<TAdat> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
        #endregion IEnumerable<TAdat> implementáció

        #region IEnumerator<T> implementáció

        public TAdat Current {get { return adatok[position]; } }

        object IEnumerator.Current { get { return Current; } }


        public bool MoveNext()
        {
            position++;
            return position < adatok.Count;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //mivel most nincs takarítanivalónk, nem kell implementálni
        }
        #endregion IEnumerator<T> implementáció
    }
}
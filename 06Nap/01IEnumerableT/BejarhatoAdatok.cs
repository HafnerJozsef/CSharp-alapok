using System;
using System.Collections;
using System.Collections.Generic;

namespace _01IEnumerableT
{
    public class BejarhatoAdatok<TAdat> : IEnumerable<TAdat>, IEnumerator<TAdat>
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

        public TAdat Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();


        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion IEnumerator<T> implementáció
    }
}
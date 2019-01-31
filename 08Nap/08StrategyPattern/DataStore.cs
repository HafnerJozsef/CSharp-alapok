using System;

namespace _08StrategyPattern
{
    public class DataStore
    {
        private int[] data;

        public DataStore(int[] data)
        {
            this.data = data;
        }

        public int SumOfOdd()
        {
            var sum = 0;
            foreach (var d in data)
            {
                if (d % 2 == 1)
                {
                    sum += d;
                }
            }
            return sum;
            //linq kifejezéssel egy sor:
            //return data.Sum(x => x % 2 == 1);
        }

        public int ProductOfEvent()
        {
            var prod = 1;
            foreach (var d in data)
            {
                if (d % 2 == 0)
                {
                    prod *= d;
                }
            }
            return prod;
        }
    }
}
using System;

namespace _01IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            //készítünk egy önmaga után eltakarító osztályt
            //var takarito = new ItselfCleaner();

            //try
            //{
            //}     
            //finally
            //{
            //    ((IDisposable)takarito).Dispose();
            //}

            using (var takarito = new ItselfCleaner())
            {//ebben a kódblokkban van a  védendő használat

            }
        }
    }
}

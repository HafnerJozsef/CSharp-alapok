using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExceptionDotNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Main try indul");

                FoProgram();

                Console.WriteLine("Main try végez");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Main catch indul");
                Console.WriteLine($"Alprogram: {ex.ToString()}");
                throw new ApplicationException("Main saját kivétel", ex);
                Console.WriteLine("Main catch végez");
            }
            finally
            {
                Console.WriteLine("Main finally indul");

                Console.WriteLine("Main finally végez");
            }

        }

        private static void FoProgram()
        {

            try
            {
                Console.WriteLine("FoProgram try indul");
                AlProgram();
                Console.WriteLine("FoProgram try végez");

            }
            catch (Exception ex)
            {
                Console.WriteLine("FoProgram catch indul");
                Console.WriteLine($"Alprogram: {ex.ToString()}");
                throw new ApplicationException("Főprogram saját kivétel", ex); 
                Console.WriteLine("FoProgram catch végez");
            }
            finally
            {
                Console.WriteLine("FoProgram finally indul");

                Console.WriteLine("FoProgram finally végez");
            }
        }

        private static void AlProgram()
        {
            try
            {
                Console.WriteLine("Alprogram try indul");
                throw new Exception("Euro utalást kellene végezni, de a megadott számla HUF!");
                Console.WriteLine("Alprogram try végez");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Alprogram catch indul");
                Console.WriteLine($"Alprogram: {ex.ToString()}");
                throw new ApplicationException("Alprogram saját kivétel", ex);
                Console.WriteLine("Alprogram catch végez");
            }
            finally
            {
                Console.WriteLine("Alprogram finally indul");

                Console.WriteLine("Alprogram finally végez");
            }
        }
    }
}

using System;

namespace _02Exeptions
{
    class Program
    {
        private static void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            Console.WriteLine($"----FirstChanseException----");
            Console.WriteLine($"{e.Exception.ToString()}");
            Console.WriteLine($"----FirstChanseException----");
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"----UnhandledException---- IsTerminating: {e.IsTerminating}");
            Console.WriteLine($"{((Exception)e.ExceptionObject).ToString()}");
            Console.WriteLine($"----UnhandledException----");
        }

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

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
                throw;
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
                throw;
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
                    throw new ConfuseCurrencyException("Euro utalást kellene végezni, de a megadott számla HUF!");
                Console.WriteLine("Alprogram try végez");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Alprogram catch indul");
                Console.WriteLine($"Alprogram: {ex.ToString()}");
                throw;
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

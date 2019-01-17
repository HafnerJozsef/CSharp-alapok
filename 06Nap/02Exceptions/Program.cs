using System;
using System.Runtime.CompilerServices;

namespace _02Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ha saját hibakezelést alkalmazunk
            try
            {//itt történik a végrehajtás
                Console.WriteLine("Main try indul");

                //var helyzet = Helyzetek.Egy;
                var helyzet = Helyzetek.Nulla;

                switch (helyzet)
                {
                    case Helyzetek.Egy:
                        Console.WriteLine($"Minden ok: {helyzet}");
                        break;
                    case Helyzetek.Ketto:
                        Console.WriteLine($"Minden ok: {helyzet}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"valami nem stimmel: {helyzet}");

                        break;
                }



                Console.WriteLine("Main try befejeződik");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Main ArgumentException catch indul");

                Console.WriteLine(ex.ToString());

                Console.WriteLine("Main ArgumentException catch befejeződik");
            }

            catch (OutOfMemoryException) { }
            catch (InvalidOperationException) { }
            catch (SystemException) { }
            catch (RuntimeWrappedException) { }
            catch (Exception ex)
            {//ez az ág kapja meg a vezérlést, ha nem kezelt kivétel történik a try ágban és létrejött kivételre igaz a szűrőfeltétel
                Console.WriteLine("Main Exception catch indul");

                Console.WriteLine(ex.ToString());

                Console.WriteLine("Main Exception catch befejeződik");

            }

            finally
            {//akármi történt ezelőt, ami ebben az ágban van, az biztosan elkezd végrehajtódni
                Console.WriteLine("Main finally indul");
                Console.WriteLine("Main finally befejeződik");
            }




            Console.ReadLine();
        }
    }
}

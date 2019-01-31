using Serilog;
using System;
using System.Threading;

namespace _07serilog
{
    class Program
    {
        static void Main(string[] args)
        {

            Log.Logger = new Serilog.LoggerConfiguration()
                                            .WriteTo.Console()
                                            .CreateLogger();

            var r = new Random();
            while (!Console.KeyAvailable) //addig fut, amig nem nyomunk le egy billentyűt
            {
                var level = r.Next(100);
                //kisebb súlyú bejegyzésből többet szeretnénk, a minél súlyosabb, annál kevesebbet kevesebbet

                if (level < 50)
                { //legkisebb súlyú, delegsűrűbben előforduló (Debug)
                    Log.Logger.Debug($"Debug: {level}");

                }
                if (level >= 50 && level < 70)
                {//info
                    Log.Logger.Information($"Information: {level}");
                }
                if (level >= 70 && level < 85)
                {//Warning
                    Log.Logger.Warning($"Warning: {level}");
                }
                if (level >= 85 && level < 95)
                {//Error
                    Log.Logger.Error($"Error: {level}");
                }
                if (level >= 95)
                {//Fatal
                    Log.Logger.Fatal($"Fatal: {level}");
                }
                Thread.Sleep(200);
            }
        }
    }
}

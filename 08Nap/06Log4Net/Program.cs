using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06Log4Net
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            //betöltjül a log4net konfigurációt az app.configból
            log4net.Config.XmlConfigurator.Configure();

            var r = new Random();
            while (!Console.KeyAvailable) //addig fut, amig nem nyomunk le egy billentyűt
            {
                var level = r.Next(100);
                //kisebb súlyú bejegyzésből többet szeretnénk, a minél súlyosabb, annál kevesebbet kevesebbet

            if (level<50)
                { //legkisebb súlyú, delegsűrűbben előforduló (Debug)

                    log.Debug($"Debug üzenet: {level}");

                }
            if (level >=50 && level<70)
                {//info
                    log.Info($"Info üzenet: {level}");
                }
            if(level>=70 && level<85)
                {//Warning
                    log.Warn($"Warn üzenet: {level}");
                }
            if(level>=85 && level<95)
                {//Error
                    log.Error($"Error üzenet: {level}");
                }
            if(level>=95)
                {//Fatal
                    log.Fatal($"Fatal üzenet: {level}");
                }
                Thread.Sleep(200);
            }
        }
    }
}

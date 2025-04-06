using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OrnekBoyama
{
    internal class Boyahane
    {

        public static void AracBoya(IBoyanabilir arac, ConsoleColor yeniRenk)
        {
            Arac gelenArac = arac as Arac;
            EkranaGoster(gelenArac, "Boyanmadan Önce");
            gelenArac.Renk = yeniRenk;
            EkranaGoster(gelenArac, "Boyandıktan Sonra");
        }


        private static void EkranaGoster(Arac arac, string mesaj)
        {
            Console.WriteLine(mesaj);
            Console.ForegroundColor = arac.Renk;
            Console.WriteLine(arac);
        }


    }
}

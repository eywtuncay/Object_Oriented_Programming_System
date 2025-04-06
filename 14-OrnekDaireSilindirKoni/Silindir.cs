using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DaireSilindirKoniOrnek
{
    internal class Silindir:Daire
    {

        public double Yukseklik { get; set; }


        public override double AlanHacimHesapla()
        {
            return base.AlanHacimHesapla() * Yukseklik;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ornek
{
    internal class Silindir:Daire
    {

        public double Yukseklik { get; set; }

        public double SilindirHacimHesapla()
        {
            return base.DaireAlanHesapla() * Yukseklik;
        }

    }
}

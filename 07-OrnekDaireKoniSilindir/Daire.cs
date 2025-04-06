using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ornek
{
    internal class Daire
    {

        public double YariCap { get; set; }

        public double DaireAlanHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }

    }
}

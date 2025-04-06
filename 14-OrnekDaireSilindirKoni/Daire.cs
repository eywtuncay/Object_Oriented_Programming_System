using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DaireSilindirKoniOrnek
{
    internal class Daire
    {

        public double YariCap { get; set; }

        public virtual double AlanHacimHesapla()
        {
            return Math.PI * YariCap * YariCap;
        }

    }
}

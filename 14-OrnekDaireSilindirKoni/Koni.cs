using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DaireSilindirKoniOrnek
{
    internal class Koni:Silindir
    {


        public override double AlanHacimHesapla()
        {
            return base.AlanHacimHesapla() * 0.3333;
        }

    }
}

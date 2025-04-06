using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Ornek
{
    internal class Koni:Silindir
    {
        
        public double KoniHacimHesapla()
        {
            return base.SilindirHacimHesapla()*0.33333;
        }

    }
}

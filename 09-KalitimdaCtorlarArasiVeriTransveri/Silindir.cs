using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KalitimdaCtorlarArasiVeriTransveri
{
    internal class Silindir:Daire
    {
        public Silindir(double r, double h):base(r)     //r'yi bir üst sınıfa gönderdik.
        {
            Console.WriteLine("Silindir nesnesi oluştu.");
        }
    }
}




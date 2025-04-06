using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Consts_Readonly
{
    internal class Matematik
    {
        public const double PI = 3.14;
        public readonly double katsayi = 1.2;

        public Matematik()
        {
            //public const double PI = 3.1412;      // Sadece tanımlandığı yerde değiştirileilir.
            katsayi = 1.65;                         // Sadece ctor içerisinde değiştirilebilir.
    }


    }



}

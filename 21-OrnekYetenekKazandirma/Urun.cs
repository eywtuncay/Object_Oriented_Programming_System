using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Ornek
{
    internal class Urun:IComparable //Sıralanabilme yeteneği kazandırdım.
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object? obj)
        {
            Urun urun = obj as Urun;
            return urun.UrunAdi.CompareTo(urun.UrunAdi);
        }

        public override string ToString()
        {
            return $"{UrunID}, {UrunAdi}, {Fiyat}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Ornek2
{
    internal class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public string Kategori { get; set; }

        override public string ToString()
        {
            return $"ID: {UrunID}, Ad: {UrunAdi}, Fiyat: {Fiyat}, Kategori: {Kategori}";
        }

    }
}

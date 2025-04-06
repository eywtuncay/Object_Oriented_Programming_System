using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ornek
{
    internal abstract class Personel
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double SatisTutari { get; set; }
        public abstract double Prim { get; set; }
        public abstract double Maas { get; set; }

    }
}

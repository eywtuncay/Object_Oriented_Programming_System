using SoruCozumDLL.Abstracts.Classes;
using SoruCozumDLL.Concretes.Bagajlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Concretes.Yolcu
{
    public class Yolcu : Kisi
    {
        public string VarisNoktasi { get; set; }
        public Bagaj? Bagaj { get; set; }
        public EvcilHayvan? EvcilHayvan { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + VarisNoktasi + " Bagaj= " + Bagaj + " Evcil Hayvan= " + EvcilHayvan;
        }
    }
}

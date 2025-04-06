using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Baş harfleri büyük yazılacak propların

namespace _02_Ornek
{
    internal class Kitap
    {

        //Kitap ile ilgili 5 properties'i olan bunlardan en az biri 3.0 öncesi olan bir class yazınız.

        public int KitapId { get; set; }
        public string KitapTuru { get; set; }
        public string YazarAdi { get; set; }
        public int YayfaSayisi { get; set; }


        private string KitapAdi;
        public string KitapAd
        {
            get { return KitapAdi; }
            set { KitapAdi = value; }
        }

    }
}

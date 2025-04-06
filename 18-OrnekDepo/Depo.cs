using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ConsoleApp1
{
    internal class Depo
    {

        private List<Urun> Urunler { get; set; } = new List<Urun>();

        public void AddUrun(Urun urun)
        {
            Urunler.Add(urun);
        }

        public List<string> TumUrunler()
        {
            List<string> list = new List<string>();
            foreach (var urun in Urunler)
                list.Add(urun.ToString());
            
            return list;
        }

        public double TumUrunlerinToplamFiyati()
        {
            double toplamfiyati = 0;
            foreach (var urun in Urunler)
                toplamfiyati += urun.Fiyat;
            return toplamfiyati;
        }


    }
}

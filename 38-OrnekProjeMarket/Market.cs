using ConsoleApp6.Abstract;
using ConsoleApp6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Market
    {
        List<Urun> urunler = new List<Urun>();

        public void UrunEkle(Urun urun)
        { 
           urunler.Add(urun);
        }

        public void UrunCikar(Urun urun)
        {
            urunler.Remove(urun);
        }

        public List<Urun> TumUrunler => urunler;

        public List<Urun> KirikUrunler()
        {
            List<Urun> kirikUrunler = new List<Urun>();
            foreach (Urun urun in urunler)
            {
                if (urun is IKirilabilir && ((IKirilabilir)urun).KirikMi)
                    kirikUrunler.Add(urun); 
            }
            return kirikUrunler;
        }

        public IEnumerable<Urun> BozukUrunler()
        {
            foreach (Urun urun in urunler)
            {
                if (urun is ISKT && ((ISKT)urun).SKT < DateTime.Now)
                    yield return urun;
            }
        }

        public IEnumerable<Urun> TarihiGesmisUrunler()
        {
            foreach (Urun urun in urunler)
            {
                if (urun is ITETT && ((ITETT)urun).TETT < DateTime.Now)
                    yield return urun;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ornek
{
    internal class Kitap
    {

        public int KitapID { get; set; }
        public string KitapAd { get; set; }
        public string YazarAd { get; set; }
        public int SayfaSayisi { get; set; }


        public Kitap(int _KitapID, string _KitapAd, string _YazarAd, int _SayfaSayisi)
        {
            KitapID = _KitapID;
            KitapAd = _KitapAd;
            YazarAd = _YazarAd;
            SayfaSayisi = _SayfaSayisi;
        }

        //uzun uzun yazmak yerine bu şekilde de kullanılabilir
        public Kitap(int _KitapID, string _KitapAd, string _YazarAd):this(_KitapID, _KitapAd, _YazarAd, 0)
        {

        }

        //uzun uzun yazmak yerine bu şekilde de kullanılabilir
        public Kitap(int _KitapID, string _KitapAd) : this(_KitapID, _KitapAd, "", 0)
        {

        }

        //uzun uzun yazmak yerine bu şekilde de kullanılabilir
        public Kitap(int _KitapID) : this(_KitapID, "", "", 0)
        {

        }



        public Kitap(string _KitapAd)
        {
            KitapAd = _KitapAd;
        }

        public Kitap()
        {
            
        }

        


    }
}

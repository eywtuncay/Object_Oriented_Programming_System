using SoruCozumDLL.Abstracts.Classes;
using SoruCozumDLL.Concretes.Bagajlar;
using SoruCozumDLL.Concretes.Koltuklar;
using SoruCozumDLL.Concretes.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Concretes
{
    public class Otobus
    {
        public Otobus(int koltukKapasitesi)
        {
            SoförKoltugu = new SoförKoltugu();
            MuavinKoltugu = new MuavinKoltugu();
            Koltuklar = new List<YolcuKoltugu>(koltukKapasitesi);
            Bagajlar = new List<Bagaj>();
            EvcilHayvanlar = new List<EvcilHayvan>(3);
            Hostes = new Hostes();
            Personeller = new List<Personel>();
        }

        public SoförKoltugu SoförKoltugu{ get; set; }
        public List<Personel> Personeller{ get; set; }
        public Hostes Hostes { get; set; }
        public MuavinKoltugu MuavinKoltugu { get; set; }
        public List<YolcuKoltugu> Koltuklar { get; set; }
        public List<Bagaj> Bagajlar { get; set; }
        public List<EvcilHayvan> EvcilHayvanlar { get; set; }


    }
}

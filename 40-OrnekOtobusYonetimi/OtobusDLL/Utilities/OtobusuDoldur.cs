using SoruCozumDLL.Abstracts.Classes;
using SoruCozumDLL.Concretes;
using SoruCozumDLL.Concretes.Bagajlar;
using SoruCozumDLL.Concretes.Koltuklar;
using SoruCozumDLL.Concretes.Personeller;
using SoruCozumDLL.Concretes.Yolcu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Utilities
{
    public static class OtobusuDoldur
    {
        private static string[] adlar = { "Cevdet", "Selami", "Kemal", "Cemal", "Dursun", "Temel", "Suat", "Fuat", "Derya" };
        private static string[] soyadlar = { "Korkmaz", "Durmaz", "Kendir", "Mavi", "Beyaz", "Bayrak", "Sancak", "Tepe", "Dere", "Irmak" };
        private static string[] hayvanAdlar = { "Leydi", "Duman", "Boncuk" };
        public static void Doldur(Otobus otobus)
        {
            Random random = new Random();

            //Şoförleri ata..
            for (int i = 0; i < 2; i++)
            {
                otobus.Personeller.Add(new Soför { PersonelID = random.Next(1, 10000), Ad = AdSec(adlar), Soyad = AdSec(soyadlar), Yas = random.Next(30, 60), Tecrube = random.Next(1, 30) });
            }

            //Host ve Muavin Oluştur.
            otobus.Personeller.Add(new Muavin { PersonelID = random.Next(1, 10000), Ad = AdSec(adlar), Soyad = AdSec(soyadlar), Yas = random.Next(20, 50), Tecrube = random.Next(1, 10) });
            otobus.Personeller.Add(new Hostes { PersonelID = random.Next(1, 10000), Ad = AdSec(adlar), Soyad = AdSec(soyadlar), Yas = random.Next(20, 50), Tecrube = random.Next(1, 30) });

            //Şoförü ata
            otobus.SoförKoltugu = new SoförKoltugu { Sofor = (Soför)otobus.Personeller[0], KonforSeviyesi = 5 };


            //Yolcuları ata
            for (int i = 0; i < otobus.Koltuklar.Capacity; i++)
            {
                int sayi = random.Next(1, 50);
                Yolcu yolcu = new Yolcu { Ad = AdSec(adlar), Soyad = AdSec(soyadlar), VarisNoktasi  = "Otogar", Bagaj = new Bagaj {BagajID  =random.Next(1000,10000), BagajAgirligi = random.Next(5,20) } };

                if (sayi < 5 && otobus.EvcilHayvanlar.Count < otobus.EvcilHayvanlar.Capacity)
                {
                    yolcu.EvcilHayvan = new EvcilHayvan { KoltukID = i+1, Ad = AdSec(hayvanAdlar), Cins = "Köpek"};
                }
                otobus.Koltuklar.Add(new YolcuKoltugu { KoltukNo = i + 1, Yolcu = yolcu });
            }
        }

        private static string AdSec(string[] adlar)
        {
            Random random = new Random();
            return adlar[random.Next(adlar.Length - 1)];
        }
    }
}

//Soru:Bir market icin; uygula yazılacaktır;
//Market; Yumurta,SiseSut,Bulgur, KagitHavlu, Bardak urunlerini satmaktadır.
//Urunlerin => ID, Ad, Fiyat ortak ozellikleri
//Urun ekleme
//Urun çıkarma
//Raporlar
// *** Tüm urunlerin Listesi
// *** Bozuk urunlerin listesi
// *** Kırık urunlerin listesi
// *** Kullanma tarihi geçmiş olan urunlerin listesi...

using ConsoleApp6;
using ConsoleApp6.Abstract;
using ConsoleApp6.Models;

Market market = new Market();
SiseSut siseSut2= new SiseSut { UrunID = 25, UrunAdi = "1lt Gunluk Sut", Fiyat = 50, SKT = DateTime.Now.AddDays(1), KirikMi = true };



int secim;
do
{
    Console.WriteLine("1-Urun Ekle");
    Console.WriteLine("2-Urun Cikar");
    Console.WriteLine("3-Tüm Ürünler");
    Console.WriteLine("4-Kırık Urunler");
    Console.WriteLine("5-Bozuk Ürünler");
    Console.WriteLine("6-Tarihi Gecmis Ürünler");
    Console.WriteLine("7-Cikis");

    secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:
            UrunleriEkle(market);
            market.UrunEkle(siseSut2);
            break;
        case 2:
            market.UrunCikar(siseSut2);
            break;
        case 3:
            Yazdir(market.TumUrunler);
            break;
        case 4:
            Yazdir(market.KirikUrunler());
            break;
        case 5:
            Yazdir(market.BozukUrunler());
            break;
        case 6:
            Yazdir(market.TarihiGesmisUrunler());
            break;
        default:
            Console.WriteLine("1-7 arası deger giriniz...");
            break;

    }

} while (secim!=7);

void UrunleriEkle(Market market)
{
    market.UrunEkle(new Bardak { UrunID=1, UrunAdi="3'lu Su bardagi", Fiyat=100, KirikMi=true });
    market.UrunEkle(new Bardak { UrunID=2, UrunAdi="6'lı Cay bardagi", Fiyat=150, KirikMi=false });
    market.UrunEkle(new Yumurta { UrunID=3, UrunAdi="15'li yumurta", Fiyat=120, KirikMi=false, SKT=DateTime.Now.AddDays(-5) });
    market.UrunEkle(new Yumurta { UrunID=6, UrunAdi="30'lu yumurta", Fiyat=200, KirikMi=true, SKT=DateTime.Now.AddDays(5) });
    market.UrunEkle(new Bulgur { UrunID = 8, UrunAdi = "Pilavlık Bulgur", Fiyat = 40, TETT = DateTime.Now.AddDays(-10) });
    market.UrunEkle(new KagitHavlu { UrunID = 13, UrunAdi = "6'lı kagit havlu", Fiyat = 190});
    market.UrunEkle(new SiseSut { UrunID = 23, UrunAdi = "Yarım Yagli 1lt", Fiyat = 40, SKT = DateTime.Now.AddDays(-3), KirikMi=false });
}

void Yazdir(IEnumerable<Urun> urunler )
{
    Console.WriteLine();
    Console.WriteLine("--------------------------");
    foreach (var urun in urunler)
        Console.WriteLine(urun);
    Console.WriteLine();
}
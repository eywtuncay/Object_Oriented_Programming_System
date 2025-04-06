
/*

Soru:
Bir Depo sınıfında: Televizyon, Buzdolabı, CamasirMakinasi tutulmaktaıdr.
Televizyon için Id, Marka, Model, Aciklama, Fiyat
Buzdolabı için Id, Marka, Model, Aciklama, Fiyat, No-Frost
CamasirMakinasi için Id, Marka, Model, Aciklama, Fiyat, YikamaKapasitesi

Bu Depoyu simule eden Sınıfları OOP kurallarına göre yazınız.
Rapor1: Depodaki tüm ürünlerin Listesi alınmalıdır.
Rapor2: Depodaki tüm ürünlerin toplam fiyatı
 
*/



using _18_ConsoleApp1;

Depo depo = new Depo();

depo.AddUrun(new Televizyon { Id = 1, Marka = "lg", Model = "smart tv", Aciklama = "fena", Fiyat = 5000 });
depo.AddUrun(new Buzdolabi { Id = 2, Marka = "beko", Model = "no frost", Aciklama = "süper", Fiyat = 3000, NoFrost = true });
depo.AddUrun(new CamasirMakinesi { Id = 3, Marka = "arçelik", Model = "8kg", Aciklama = "süper", Fiyat = 2000, YikamaKapasitesi = 8 });


foreach (var item in depo.TumUrunler())
{
    Console.WriteLine(item);
}


Console.WriteLine("Toplam: " + depo.TumUrunlerinToplamFiyati());

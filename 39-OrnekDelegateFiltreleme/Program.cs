
using _38_Ornek2;

List<Urun> urunler = new List<Urun>()
{
    new Urun{UrunID=1, UrunAdi="Defter", Fiyat=50, Kategori="Kırtasiye"},
    new Urun{UrunID=2, UrunAdi="kalem", Fiyat=20, Kategori="Kırtasiye"},
    new Urun{UrunID=3, UrunAdi="Futbol Topu", Fiyat=150, Kategori="Hobi"},
    new Urun{UrunID=4, UrunAdi="Raket", Fiyat=5000, Kategori="Hobi"},
    new Urun{UrunID=5, UrunAdi="500 Parça Puzzle", Fiyat=500, Kategori="Puzzle"},
};


// 1) Id'si 5 olan ürünü bulan metodu yaz.
// 1) kategorisi hobi olan ürünleri bulan metodu yaz.
// 1) UrunAdi'nda 'u' geçen ürünleri bulan metodu yaz.



//// 1) Id'si 5 olan ürünü bulan metodu yaz.
//Urun IdUrunBul(List<Urun> urunler, int id)
//{
//    return urunler.FirstOrDefault(urun => urun.UrunID == id);
//}


//// 1) kategorisi hobi olan ürünleri bulan metodu yaz.
//List<Urun> KategoriUrunBul(List<Urun> urunler, string kategori)
//{
//    return urunler.Where(urun => urun.Kategori.Equals(kategori, StringComparison.OrdinalIgnoreCase)).ToList();
//}


//// 1) UrunAdi'nda 'u' geçen ürünleri bulan metodu yaz.
//List<Urun> UrunAdiUrunBul(List<Urun> urunler, string substring)
//{
//    return urunler.Where(urun => urun.UrunAdi.Contains(substring, StringComparison.OrdinalIgnoreCase)).ToList();
//}


//var idIleUrun = IdUrunBul(urunler, 5);
//var kategoriIleUrunler = KategoriUrunBul(urunler, "Hobi");
//var urunAdiIleUrunler = UrunAdiUrunBul(urunler, "u");


//Console.WriteLine("ID'si 5 olan ürün: " + (idIleUrun != null ? idIleUrun.UrunAdi : "Bulunamadı"));
//Console.WriteLine("'Hobi' kategorisindeki ürünler: " + string.Join(", ", kategoriIleUrunler.Select(urun => urun.UrunAdi)));
//Console.WriteLine("Adında 'u' harfi geçen ürünler: " + string.Join(", ", urunAdiIleUrunler.Select(urun => urun.UrunAdi)));




// Kısa yol --> Delegate ile kendi filtremiz yazdık.

Yazdir(Filtrele(x => x.UrunID == 5));
Yazdir(Filtrele(x => x.Kategori == "Hobi"));
Yazdir(Filtrele(x => x.UrunAdi.Contains("u")));




IEnumerable<Urun> Filtrele (Func<Urun, bool> where)
{
    return urunler.Where(where);
}

void Yazdir(IEnumerable<Urun> urunler)
{
    foreach (var item in urunler)
    {
        Console.WriteLine(item);
    }
}


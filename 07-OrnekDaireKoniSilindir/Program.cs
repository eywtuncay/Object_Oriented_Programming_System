

// Soru: Daire, Silindir, Koni nesnelerini oluşturunuz. Bu nesnelerin alan veya hacim hesaplamalarını yapınız.
// Daire: pi * r * r
// Silindir: pi * r * r * h
// Koni:  pi * r * r * 0,3333



using _07_Ornek;

Daire daire = new Daire() { YariCap = 3 };
Silindir silindir = new Silindir() { YariCap = 3, Yukseklik = 10 };
Koni koni = new Koni() { YariCap = 3, Yukseklik = 10 };


Console.WriteLine(daire.DaireAlanHesapla);
Console.WriteLine(silindir.SilindirHacimHesapla);
Console.WriteLine(koni.KoniHacimHesapla);


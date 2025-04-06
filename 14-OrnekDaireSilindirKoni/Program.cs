

/*

Dire, Silindir, Koni şekillerinin alan hesaplamalarını yapan programı oop ve polimorphizm kullanarak yazınız.
 
// Daire: pi * r * r
// Silindir: pi * r * r * h
// Koni:  pi * r * r * 0,3333

*/



using _14_DaireSilindirKoniOrnek;

Daire daire = new Daire() { YariCap = 3 };
Silindir silindir = new Silindir() { YariCap = 3, Yukseklik = 5 };
Koni koni = new Koni() { YariCap = 4, Yukseklik = 5 };


List<Daire> sekiller = new List<Daire>();
sekiller.Add(daire);
sekiller.Add(koni);
sekiller.Add(silindir);

foreach (var sekil in sekiller)
{
    Console.WriteLine(sekil.AlanHacimHesapla());
}


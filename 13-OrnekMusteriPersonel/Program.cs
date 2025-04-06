

/*

Soru:
Bir ArrayList oluşturun, içerisine Musteri, Personel sınıfları atınız.
Personel'de PersonelId, Ad, Soyad, Maas.
Musteri'de MusteriId, Ad, Soyad, CariDurum. bilgileri tutulacak

Tüm listeyi ekrana yazdıran kodu yazınız.
 
*/

using _13_Ornek;
using System.Collections;

Console.WriteLine("");


ArrayList List = new ArrayList();

List.Add(new Musteri { MusteriId = 1, Ad = "Tuncay", Soyad = "Albayrak", CariDurum = "Borçlu" });

List.Add(new Personel { PersonelId = 1, Ad = "Tuncay", Soyad = "Albayrak", Maas = 150 });


foreach (var item in List)
{
    Console.WriteLine(item);
}


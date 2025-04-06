
/*

Bir firmada tam zamanlı ve yarı zamanlı olmak üzere 2 çeşit satış elemanı çalışmaktadır.

Tam zamanlı çalışan personellerin maaşı: Taban ücret + prim şeklinde hesaplanır.
Prim yaptığı satış tutarı üzerinden aşağıdaki gibi hesaplanacaktır.

Prim: 250000 < ise yüzde 1
      250000 >= ve 500000 ise yüzde 2
      500000 >= ise yüzde 3

Yarı zamanlı personellerin maaşı ise 
Çalıştığı saat * saat ücreti + prim şeklinde olacaktır.
Prim ise satışın sadece yüzde 1'i olacaktır.

Personelin ad, soyad bilgisi de tutulacak
Ad, Soyad, Id tüm personeller için ortak
Taban ücreti kullanıcı girecek.

Bu personellerin maaşını hesaplayan uygulamayı C# da oop kullanarak yazınız.
Class Object ve Inheritance kullanılacak

16.02

*/



using _10_Ornek;



TamZamanli tamZamanliPersonel = new TamZamanli("tuncay", "albayrak", 2, 120, 100000);
Console.WriteLine($"Maaş: {tamZamanliPersonel.MaasHesapla()} TL");


YariZamanli yariZamanli = new YariZamanli("tuncay2", "albayrak2", 2, 120, 150, 100000,123);
Console.WriteLine($"Maaş: {yariZamanli.MaasHesapla()} TL");



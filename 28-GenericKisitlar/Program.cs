
/*

GENERIC KISITLAR
1) Class
2) Struct
3) Inheritiance
4) Interface
5) New()


*/



using _28_GenericKisitlar;

Test<string> test1 = new Test<string>();
Test<object> test2 = new Test<object>();
Test<Urun> test3 = new Test<Urun>();


//Değer tipli tipler kullanılamaz.
//Test<int> test4 new Test<int>();


Islem<int> islem1 = new Islem<int>();
Islem<bool> islem2 = new Islem<bool>();


//Referans Tipli kabul etmez.
//Islem<string> islem3 = new Islem<string>();



Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------------------");



//---- Kalıtım ile

Personelslemleri<Memur> personelslemleri2 = new Personelslemleri<Memur>();
Personelslemleri<Hizmetli> personelslemleri = new Personelslemleri<Hizmetli>();
Personelslemleri<Mudur> personelslemleri3 = new Personelslemleri<Mudur>();

//Personel sınıfından kalıtım almadığı için hata verir.
//Personelslemleri<Guvenlik> personelslemleri5 = new Personelslemleri<Guvenlik>();




//---- Interface ile

SilahRuhsatIslemleri<Guvenlik> ruhsatIslemleri1 = new SilahRuhsatIslemleri<Guvenlik>();
SilahRuhsatIslemleri<Mudur> ruhsatIslemleri2 = new SilahRuhsatIslemleri<Mudur>();

//ISilahTasiyabilir Interface', ile implemente edilmediği için hata verir.
//SilahRuhsatIslemleri<Hizmetli> ruhsatIslemleri3 = new SilahRuhsatIslemleri<Hizmetli>();



//---- Birden Fazla Kısıt ile
MuhasebeIslemleri<Memur> muhasebeIslemleri1 = new MuhasebeIslemleri<Memur>();
MuhasebeIslemleri<Mudur> muhasebeIslemleri2 = new MuhasebeIslemleri<Mudur>();

//Hizmetli sınıfı içerisinde varsayılan ctor olmadığı için hata verir.
//MuhasebeIslemleri<Hizmetli> muhasebeIslemleri2 = new MuhasebeIslemleri<Hizmetli>();







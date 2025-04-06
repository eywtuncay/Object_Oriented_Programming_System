
/*

Struct (Yapı): Struct'lar, değer türleri olarak bilinir.
Bellekte doğrudan stack (yığın) üzerinde tutulurlar.
Eğer struct'ın boyutu 16 bayt veya daha küçükse, bu struct, doğrudan stack'te tutulur.
Stack'te saklanmak, bu türlerin hafıza erişim hızını artırabilir çünkü
stack, işlemci tarafından hızlıca erişilebilen bir hafıza bölgesidir.
int, double, char .... stack de tutulan yapılar struct'dır.

Class (Sınıf): Class'lar ise referans türleridir ve her zaman heap (yığın) üzerinde saklanır.
Eğer bir struct 16 baytın üzerinde bir boyuta sahipse, -
.NET'te genellikle bu struct, heap üzerinde tutulur ve bir class gibi referans türüne dönüşür.
Bunun nedeni, stack üzerinde daha büyük yapıları saklamak, -
stack'te yüksek bir bellek kullanımı ve potansiyel taşmalar oluşturabilir.



Generic de artık tip de parametre gibi davranır.
 
*/


//Stack Overflow --> Stack'te yer kalmadığında oluşan hata. --> Recursive fonksiyonlarda oluşabilir.
//Recorsive Function --> Kendi kendini çağıran foksiyonlar. --> Faktoriyel hesaplama gibi.

using _25_Generic;

//int Faktoriyel(int sayi)
//{
//    if (sayi == 1) return 1;                // Eklemezsek eğer stack overflow oluşur. Sonsuza kadar gider. Stack dolar
//    return sayi * Faktoriyel(sayi - 1);
//}

//Console.WriteLine(Faktoriyel(5));



// ------------------------------------------------------------------------ //



//STRUCT


Nokta nokta = new Nokta();

nokta.X = 12;
nokta.Y = 13;

Console.WriteLine(nokta.Koordinat());




//int sayi;                 //Hata verir çünkü değeri yok. Struck da değeri olmalı.
int sayi = new int();       //Bu şekilde varsayılan bir değer oluşturur. Hata vermez.
Console.WriteLine(sayi);







//GENERICS


//------Generic Kullanmadan Metot

using _26_Generic;

int[] sayilar = { 1, 2, 3, 4 };
void YazSayilar(int[] sayilar)
{
    foreach (var sayi in sayilar)
         Console.WriteLine(sayi);
 
}


string[] sehirler = { "Ankara", "İstanbul", "İzmir" };
void YazSehirler(string[] sehirler)
{
    foreach (var sehir in sehirler)
        Console.WriteLine(sehir);
}


YazSayilar(sayilar);        //Generic Kuallanmadığım için 2 tip için de metot yazdım.
YazSehirler(sehirler);      //Generic Kuallanmadığım için 2 tip için de metot yazdım.



//------Generic Kullanarak Metot

void EkranaYazdir<T>(T[] dizi)
{
    foreach (T t in dizi)
        Console.WriteLine(t);
}

EkranaYazdir<int>(sayilar);         //Generic ile tipi belirterek tek metot ile yazdım.
EkranaYazdir<string>(sehirler);     //Generic ile tipi belirterek tek metot ile yazdım.



Console.WriteLine("----------------------------------------------------");
Console.WriteLine("----------------------------------------------------");




Depo<Televizyon> depo = new Depo<Televizyon>();
Depo<Buzdolabı> depo2 = new Depo<Buzdolabı>();





//Collections

/*

Koleksiyonların çalışma mekaniği

Mümkün oldukça Generic yapıları kullanmalıyız.
Çünkü tip belli
Tip belli olmadığında tip dönüşüm işlemi yapar ve çok performans harcar.

 
*/


List<int> sayilar = new List<int>();
for (int i = 0; i < 5; i++)
{
    sayilar.Add(i);
}



Console.WriteLine($" Adet: {sayilar.Count}. Kapasite: {sayilar.Capacity}");



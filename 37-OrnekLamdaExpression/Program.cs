
//Lamda expression?




List<int> sayilar = new List<int>() { 34, 55, 11, 33, 42, 12, 77, 98, 44 };
//Tek sayıları bulunuz.

//1. yöntem
//var tekSayilar = sayilar.Where(sayi => sayi % 2 != 0).ToList();
//Console.WriteLine("Tek sayılar: " + string.Join(", ", tekSayilar));


//--- Predicate

Predicate<int> predicate = new Predicate<int>(SayiTekMi);

//2. yöntem
Yazdir(sayilar.FindAll(predicate));

bool SayiTekMi(int sayi)
{
    return sayi % 2 == 1;
}

//3. yöntem
Yazdir(sayilar.FindAll(SayiTekMi));

//4. yöntem
Yazdir(sayilar.FindAll(delegate (int sayi) { return sayi % 2 == 1; }));

//5. yöntem
Yazdir(sayilar.FindAll(x => x % 2 == 1));

//Bu üstteki x => x yapısı linq sorgularında da kullanılıyor, buna bir bak.




void Yazdir(IEnumerable<int> sayilar)
{
	foreach (var sayi in sayilar)
	{
        Console.Write(sayi+ " ");
	}
    Console.WriteLine();
}
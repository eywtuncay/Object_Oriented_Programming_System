

//NULLABLE TYPES

/*

Değer tipleri C# da Null olamaz. Çünkü Ram de değerin kendisini tutar.
Ama nullable işaretlenebilir.

Bunun sebebi ise Database ile uyumlu şekilde çalışabilmektir.

Database de oluşturulan değerler default olarak Null olabilir.
C# ile ilişkili bir şekilde kullanılabilmesi için C# da nullable işaretlenir.

Aslında yine null olmaz Nullable sturct'ı ile sarılır.


*/



Nullable<int> sayi1 = null;     //Uzun hali

int? sayi2 = null;              //Kısa hali


Console.WriteLine(sayi2.GetValueOrDefault());   // Değeri varsa getir yoksa Defaul'u getir. Default 0

Console.WriteLine(sayi2 ?? 5);                  // GetValueOrDefault kısa hali. Default'a 5 koydum.




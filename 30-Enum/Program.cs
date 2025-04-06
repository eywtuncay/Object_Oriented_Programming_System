
/*

------ ENUM ------

Enum, C#'ta bir türdür ve sabit değerlerin adlarla temsil edilmesini sağlar.
Bir enum, bir grup ilişkili sabit değeri bir araya getirmenizi sağlar,
bu sayede kodunuzda daha anlamlı ve okunabilir bir yapı oluşturabilirsiniz.


Enum kullanmanın en büyük avantajlarından biri, sabit değerlerin bir adla temsil edilmesidir.
Bu, kodun okunabilirliğini artırır ve hata yapma olasılığını azaltır.
Örneğin, bir renk seçeneği gibi belirli sabit değerlerin bir arada kullanılması gerektiğinde,
her bir sabiti numara yerine, anlamlı bir adla kullanmak daha uygun olur.

Özet:
Enum, anlamlı sabit değerleri gruplamak için kullanılır.
Enum, sayıların yerine anlamlı isimler kullanarak kodunuzu daha okunabilir hale getirir.
Flags özniteliği, birden fazla enum değerini aynı anda temsil etmek için kullanılır.



enum Renkler
{
    Kirmizi,  // Varsayılan değer: 0
    Mavi,     // Varsayılan değer: 1
    Yesil,    // Varsayılan değer: 2
    Sarı      // Varsayılan değer: 3
}


*/




//ConsoleColor bir Enum. --> Her rengin bir sayısal değeri vardır.
using _30_Enum;

Console.WriteLine("Merhaba Dünya");
Console.ForegroundColor = ConsoleColor.Red;


Console.WriteLine("-------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------");



Gunler gunler = Gunler.Cuma;
Console.WriteLine(gunler);
Console.WriteLine((int)gunler);


Personel personel = new Personel();
personel.IzinGunu = Gunler.Cuma;







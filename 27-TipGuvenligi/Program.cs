


using System.Collections;

ArrayList liste1 = new ArrayList();

liste1.Add(12);
liste1.Add(3);
liste1.Add(5);
liste1.Add("AA");               //String ekledim

int toplam = 0;
foreach (int sayi in liste1)
{
    toplam += sayi;             //Listede string olduğu için toplayamaz ve hata verir. DesignTime'da hata vermez.
}

Console.WriteLine(toplam);


Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------");


List<int> liste2 = new List<int>();
liste2.Add(12);
//liste2.Add("AA");     //DesignTime'da hata verir. Çünkü tip güvenliği var.



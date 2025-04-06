

using System.Collections;

ArrayList liste1 = new ArrayList();
List<int> liste2 = new List<int>();



DateTime basla, bitir;
TimeSpan delta = new TimeSpan();


int sayac = 99999;


basla = DateTime.Now;

for (int i = 0; i < sayac; i++)
{
    liste1.Add(i);
    int sayi = (int)liste1[i];
}

bitir = DateTime.Now;

delta = bitir - basla;
Console.WriteLine($"ArrayList= {delta.TotalMicroseconds}");







basla = DateTime.Now;

for (int i = 0; i < sayac; i++)
{
    liste2.Add(i);
    int sayi = (int)liste1[i];
}

bitir = DateTime.Now;

delta = bitir - basla;
Console.WriteLine($"List= {delta.TotalMicroseconds}");










/*

Dosyalar ikiye ayrılır text dosyalar ve binary dosyalar.
 

Json dosyalarını diskte tutulacak şekilde çevirmeye serilization ve deserilization denir.
stringden objeye objeden stringe çevirme


*/

Console.WriteLine("Dosyalar");

//---Text Dosya Oluşturma
//StreamWriter sw = new StreamWriter("data.txt",true);
//sw.WriteLine("emened 321");
//sw.Close();




//---Text Dosyadan Okuma
//StreamReader sr = new StreamReader("data.txt");

//while (!sr.EndOfStream)                         //Verileri satır satır okur.
//{
//    Console.WriteLine(sr.ReadLine());
//}

////Console.WriteLine(sr.ReadToEnd());            //Tüm verileri tek seferde okur.
//sr.Close();



/*

Soru: 1 ile 10 arası not verilen bir sistemde; 100 öğrenci için rastgele notları oluşturup, bu notları bir dosyaya yazdırınız.
Daha sonra tüm not verilerini bu dosyadan okuyup her notun frekansını hesaplayınız.
Öğrenci adı gibi verileri tutmaya gerek yoktur. Dosyada sadece notlar bulunmaktadır.

*/


Random rnd = new Random();
int[] notlar = new int[100];


StreamWriter sw = new StreamWriter("notlar.txt");
for (int i = 0; i < notlar.Length; i++)
{
    notlar[i] = rnd.Next(1, 11);
    sw.WriteLine(notlar[i]);
}
sw.Close();



string[] notSatirlari = File.ReadAllLines("notlar.txt");

int[] okunanNotlar = new int[notSatirlari.Length];
for (int i = 0; i < notSatirlari.Length; i++)
{
    okunanNotlar[i] = int.Parse(notSatirlari[i]);
}


int[] frekanslar = new int[10];
foreach (var not in okunanNotlar)
{
    frekanslar[not - 1]++;
}


Console.WriteLine("Not Frekansları:");
for (int i = 0; i < frekanslar.Length; i++)
{
    Console.WriteLine($"Not {i + 1}: {frekanslar[i]} kez");
}


// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using SoruCozumDLL.Concretes;
using SoruCozumDLL.Utilities;

Console.WriteLine("Hello, World!");

Otobus otobus = new Otobus(40);

OtobusuDoldur.Doldur(otobus);

foreach (var personel in otobus.Personeller)
{
    Console.WriteLine(personel);
}

foreach (var item in otobus.Koltuklar)
{
    Console.WriteLine(item);
}


foreach (var item in otobus.EvcilHayvanlar)
{
    Console.WriteLine("asd");
    Console.WriteLine(item);
}
string strJSON = JsonConvert.SerializeObject(otobus);
StreamWriter streamWriter = new StreamWriter("data.json");
streamWriter.WriteLine(strJSON);
streamWriter.Close();
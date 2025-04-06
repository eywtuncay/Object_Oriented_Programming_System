

using _20_YetenekKazandırma;

List<string> sehirler = new List<string>() { "İstanbul", "Ankara", "İzmir" };

foreach(var item in sehirler)
{
    Console.WriteLine(item);
}


Console.WriteLine("-------------------------------------");



//Forech IEnumerable interface'i sayesinde kullanılır.

Depo depo = new Depo();

foreach (var item in depo)
{
    Console.WriteLine(item);
}



/*

--- DELEGATE (TEMSİLCİ) ---

Delegate kullanmıyorsan C# ın %50'sini kullanmıyorsun demektir.

Delegate'ler metot taşımak için kullanılır.
Her delegate her metotu taşımaz.

2 kural var
bir metotun imzası ile return type'ının aynı olması gerekir.

Delaget'ler return type'ı ve imzası aynı olan metotları taşır.

 
Function ile Stored Procedure arasındaki fark fonskiyonun geriye değer döndürebilmesidir.
Action geriye değer döndürmeyen metotları kullanır.

En popüler ve çok kullandığımız 2 delegate --> Func, Action


Event yazacaksak oradak kullanacağız.


*/


using _36_Delegate;




//Test test = new Test();

Temsilci temsilci = new Temsilci(Test.Merhaba);     //Merhaba metodunu bağladım.
temsilci += Test.Hello;             //Hello metodunu bağladım.
temsilci += Test.Hello;             //Hello metodunu bağladım.
temsilci += Test.Yaz;				//Yaz metodunu bağladım.
//temsilci += Test.IkiKatiniAl;     //Bağlanamaz --> İmza uymuyor.
//temsilci += Test.KareAl;          //Bağlanamaz --> return type uymuyor.

//Aşağıda Delegate'nin imzasını ve tipini belirttim.

temsilci();


Console.WriteLine("-------------------------------------------------------------------------");


foreach (Delegate @delegate in temsilci.GetInvocationList())
{
    Console.WriteLine(@delegate.Method.Name);       //Metotların isimlerini yazdırdım.


	if (@delegate.Method.Name == "Yaz")
	{
        Console.WriteLine("Dinamik çağırma");
		@delegate.DynamicInvoke();
	}
}





//------- ANONOİM METOD

var t = delegate ()								// t değişkenine metot ataması yaptım.
{
	Console.WriteLine("Anonim Metod...");
};


t();	// t ile metodu çağırdım










public delegate void Temsilci();        // İlk olarak Delegate'nin imzasını ve tipini belirttim.

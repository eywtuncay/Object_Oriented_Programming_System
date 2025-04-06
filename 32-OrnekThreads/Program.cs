





void Yaz()
{
	for (int i = 0; i < 100; i++)
	{
		Thread.Sleep(10);
        Console.WriteLine("Yaz "+i);
	}
}


void say()
{
	for (int i = 0; i < 100; i++)
	{
        Thread.Sleep(10);
        Console.WriteLine("Say "+i);
	}
}




//Yaz();
//say();



ThreadStart ts1 = new ThreadStart(say);
ThreadStart ts2 = new ThreadStart(Yaz);

ts1();
ts2();





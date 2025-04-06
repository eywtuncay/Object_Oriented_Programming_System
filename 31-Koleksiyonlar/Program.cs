

/*

----- KOLEKSİYONLAR -----

Stack       -->  Stack<>        --> LIFO        --> Son Giren İlk Çıkar (Şarjör)
Queue       -->  Queue<>        --> FIFO        --> İlk Giren İlk Çıkar
Hashtable   -->  Dictionary<>

 
*/


//Stack
Stack<int> stack = new Stack<int>();

stack.Push(44);
stack.Push(23);
stack.Push(5);
stack.Push(1);


Console.WriteLine(stack.Peek());    //En son ekleneni verir.
Console.WriteLine(stack.Count);     //Eleman sayısı

Console.WriteLine(stack.Pop());     
Console.WriteLine(stack.Count);



//Queue
Queue<string> queue = new Queue<string>();
queue.Enqueue("İstanbul");
queue.Enqueue("Ankara");
queue.Enqueue("İzmir");

Console.WriteLine(queue.Dequeue());     //İlk ekleneni verir.
Console.WriteLine(queue.Count);

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Count);



//Dictionary
Dictionary<int, string> sehirler = new Dictionary<int, string>();
sehirler.Add(1, "Adana");
sehirler.Add(34, "İstanbul");

Console.WriteLine(sehirler[34]);    //İstanbul







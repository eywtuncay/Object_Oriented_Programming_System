
/*

Boyoma örneği:

Araclar adında bir Class'ım olacak.
Bu class içinde Boyama adında bir metot olacak.

Araçlar Classından türetilen herhangi bir classın Boyama metotu çağrıldığında
bu çağrılan class'ın IBoyanabilir interface'i var mı diye kontrol edeceğiz eğer var ise boyama işlemi yapılacak.

*/



using _22_OrnekBoyama;

Ferrari ferrari = new Ferrari();
Bisiklet bisiklet = new Bisiklet();

Boyahane.AracBoya(ferrari, ConsoleColor.Red);
//Boyahane.AracBoya(bisiklet, ConsoleColor.Green);    //Gönderemiyorum uyarıyor.


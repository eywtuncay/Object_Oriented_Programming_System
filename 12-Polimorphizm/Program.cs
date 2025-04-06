
using _12_Polimorphizm;

//OOP: Polimorphizm



Araba araba = new Araba();
Ferrari ferrari = new Ferrari();
Serce serce = new Serce();


araba.Sur();    //Araba Sür
ferrari.Sur();  //Ferrari Sür
serce.Sur();    //Serce Sür


Console.WriteLine("-------------------------------------------------");

//Koleksiyon oluşturuyoruz. Override eklenmemiş hali
Araba araba2 = new Araba();
Araba ferrari2 = new Ferrari();
Araba serce2 = new Serce();


araba2.Sur();       //Araba Sür
ferrari2.Sur();     //Araba Sür
serce2.Sur();       //Araba Sür


Console.WriteLine("-------------------------------------------------");


//Override eklenmemiş hali
Araba araba3 = new Araba();
Araba ferrari3 = new Ferrari();
Araba serce3 = new Serce();


araba3.Sur();       //Araba Sür
ferrari3.Sur();     //Ferrari Sür
serce3.Sur();       //Serce Sür



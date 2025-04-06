


using _06_Uygulama;

//Personel personle = new Personel();       //Abstrac olduğu için instance oluşturulamaz.

GiseMemuru giseMemuru = new GiseMemuru();

//PersonelIslemleri personelIslemleri = new PersonelIslemleri();    //Static olduğu için kullanılamaz.


PersonelIslemleri.IseAl();  //Direkt metotu class ile kullanabilirim. Static


Market market = new Market();
//market.UrunEkle();        //Ulaşamam hata verir.
Market.UrunEkle();          //Ulaşabilirim. Çünkü sınıf isminden metota eriştim. Çünkü static bir metot.





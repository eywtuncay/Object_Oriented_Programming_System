

using _19_Interface;

Personel personel = new Personel();
Musteri musteri = new Musteri();

personel.Islem();               // Personel tipinde tuttuğum için Test metotuna ulaşamam.
musteri.Islem();                // Musteri tipinde tuttuğum için Test metotuna ulaşamam.

IArayuz obj1 = new Personel();
IArayuz obj2 = new Musteri();

obj1.Test();        // IArayuz tipinde tuttuğum için Test metotuna ulaşabiliyorum.



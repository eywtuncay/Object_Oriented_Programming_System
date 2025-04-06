using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Delegate
{
    internal class Test
    {

        public static void Yaz()
        {
            Console.WriteLine("Yaz Medodu");
        }


        public static void Merhaba()
        {
            Console.WriteLine("Merhaba");
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }

        public static int KareAl(int sayi)
        {
            return sayi * sayi;
        }

        public static void IkiKatiniAl(int s)
        {
            Console.WriteLine(s*2);
        }


    }
}

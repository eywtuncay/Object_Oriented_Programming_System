using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConsoleApp1
{
    internal class Personel
    {

        public int personelID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }


        public Personel()
        {
            
        }

        public Personel(int id)     //Parametreli ctor. Metot Overloading
        {
            personelID = id;
        }


    }
}

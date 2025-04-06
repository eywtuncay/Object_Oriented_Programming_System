using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ConsoleApp1
{
    internal class Urun(int id, string ad)          //Primary ctor
    {


        public int UrunID { get; set; } = id;
        public string UrunAdi { get; set; } = ad;



    }
}

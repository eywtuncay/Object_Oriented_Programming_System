using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ConsoleApp1
{
    internal class CamasirMakinesi:Urun
    {
        public int YikamaKapasitesi { get; set; }


        public override string ToString()
        {
            return base.ToString() + $", Yikama Kapasitesi: {YikamaKapasitesi}";
        }

    }
}

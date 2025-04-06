using SoruCozumDLL.Abstracts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Concretes.Bagajlar
{
    public class EvcilHayvan : Canli
    {
        public int KoltukID { get; set; }
        public string Cins { get; set; }

        public override string ToString()
        {
            return KoltukID + " " + " " + base.ToString() +  Cins;
        }
    }
}

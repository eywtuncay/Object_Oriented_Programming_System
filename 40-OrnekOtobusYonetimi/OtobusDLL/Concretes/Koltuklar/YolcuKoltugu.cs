using SoruCozumDLL.Abstracts.Classes;
using SoruCozumDLL.Concretes.Yolcu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Concretes.Koltuklar
{
   public class YolcuKoltugu : Koltuk
    {
        public int KoltukNo { get; set; }
        public Yolcu.Yolcu? Yolcu { get; set; }

        public override string ToString()
        {
            return KoltukNo + " " + Yolcu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Concretes.Bagajlar
{
   public class Bagaj
    {
        public int BagajID { get; set; }
        public int KoltukID { get; set; }
        public double BagajAgirligi { get; set; }
        public override string ToString()
        {
            return BagajID + " " + KoltukID + " " + BagajAgirligi ;
        }
    }
}

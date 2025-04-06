using SoruCozumDLL.Abstracts.Classes;
using SoruCozumDLL.Abstracts.Interfaces;
using SoruCozumDLL.Concretes.Yolcu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Concretes.Koltuklar
{
   public class SoförKoltugu : Koltuk
    {
        public IAracKullanabilir Sofor{ get; set; }
        public int KonforSeviyesi { get; set; } //1-5
    }
}

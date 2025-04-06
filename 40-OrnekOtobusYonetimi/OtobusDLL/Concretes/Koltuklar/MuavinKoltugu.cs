using SoruCozumDLL.Abstracts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumDLL.Concretes.Koltuklar
{
    public class MuavinKoltugu : Koltuk
    {
        public Personel personel { get; set; }
        public bool AcikMi { get; set; } = false;
    }
}

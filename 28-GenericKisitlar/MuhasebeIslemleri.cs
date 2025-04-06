using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_GenericKisitlar
{
    internal class MuhasebeIslemleri<T> where T : Personel, new()
    {
        //Birden fazla kısıt bir sınıfa uygulanabilir.
        //Birden fazla kısı var ise new en sonda olmak zorundadır.
    }
}

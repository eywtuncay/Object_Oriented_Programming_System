using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_YetenekKazandırma
{
    internal class Depo : IEnumerable
    {
        List<string> urunler = new List<string>() { "Defter", "Kalem", "Silgi" };

        public IEnumerator GetEnumerator()
        {
            return urunler.GetEnumerator();
        }
    }
}

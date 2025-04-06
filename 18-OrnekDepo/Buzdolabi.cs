using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ConsoleApp1
{
    internal class Buzdolabi:Urun
    {
        public bool NoFrost { get; set; }


        public override string ToString()
        {
            return base.ToString() + $", NoFrost: {NoFrost}";
        }

    }
}

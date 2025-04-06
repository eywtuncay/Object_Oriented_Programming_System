using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OrnekBoyama
{
    internal abstract class Arac
    {
        public ConsoleColor Renk { get; set; }

        protected Arac()
        {
            Renk = (ConsoleColor) new Random().Next(1, 16);
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

    }
}

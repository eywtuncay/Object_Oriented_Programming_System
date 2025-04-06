using ConsoleApp6.Abstract;
using ConsoleApp6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    internal class Yumurta : Urun, IKirilabilir, ISKT
    {
        public DateTime SKT { get; set ; }
        public bool KirikMi { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + KirikMi + " " + SKT.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_InterfaceSegregation
{
    internal class DeveKusu : ICanli
    {
        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            //Interface'den gelen hiçbir yapı atıl kalamaz.
            //throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}

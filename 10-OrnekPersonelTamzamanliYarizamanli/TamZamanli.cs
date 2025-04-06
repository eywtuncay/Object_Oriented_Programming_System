using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Ornek
{
    internal class TamZamanli : Personel
    {

        public double TabanUcret { get; set; }

        public override double Prim
        { 
            get
            {
                double prim;
                if (SatisTutari < 250000)
                    prim = SatisTutari * 0.01;
                else if (SatisTutari >= 250000 && SatisTutari < 500000)
                    prim = SatisTutari * 0.02;
                else if (SatisTutari >= 500000)
                    prim = SatisTutari * 0.01;
                else
                    prim = 0;
                
                return prim;

            }

        }

        public override double Prim { set => throw new NotImplementedException(); }
        public override double Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

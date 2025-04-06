using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Ornek
{
    internal class Personel
    {

        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }

        public override string ToString()
        {
            return $"PersonelId: {PersonelId}, Ad: {Ad}, Soyad: {Soyad}, Maas: {Maas}";
        }

    }
}

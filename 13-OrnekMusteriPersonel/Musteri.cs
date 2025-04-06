using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Ornek
{
    internal class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string CariDurum { get; set; }

        public override string ToString()
        {
            return $"MusteriId: {MusteriId}, Ad: {Ad}, Soyad: {Soyad}, CariDurum: {CariDurum}";
        }

    }
}


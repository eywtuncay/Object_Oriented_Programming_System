using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ConsoleApp1
{
    internal abstract class Urun
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, Marka: {Marka}, Model: {Model}, Aciklama: {Aciklama}, Fiyat: {Fiyat}";
        }

    }

}

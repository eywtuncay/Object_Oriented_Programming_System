using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Interface
{
    internal interface IArayuz
    {

        //Genelde böyle kullanılır. Gövdesiz metotlar.
        void Islem();


        //Gövdeli metot
        //C#'a sonradan gelmiştir. Artık Interface içerisi gövdeli metotlar da tanımlanabilir.
        //Ancak bunlara sadece Interface üzerinden ulaşabiliriz.
        string Test()
        {
            return "Arayüz içinde gövdeli yapılar olur mu?";
        }


    }
}

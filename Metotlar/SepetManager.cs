using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2()
        {

        }
    }
}

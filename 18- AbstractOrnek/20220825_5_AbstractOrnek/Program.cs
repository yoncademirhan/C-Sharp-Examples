using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220825_5_AbstractOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Koltuk k = new Koltuk();
            k.Renk = "Beyaz";
            k.Kumas = "Saten";
            k.OzellikYaz();

            Masa m = new Masa();
            m.Malzeme = "Ahşap";
            m.Renk = "Ceviz";
            m.OzellikYaz();


            Console.ReadKey();
        }
    }
}

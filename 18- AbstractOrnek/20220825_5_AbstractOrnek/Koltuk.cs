using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220825_5_AbstractOrnek
{
    public class Koltuk : Mobilya
    {
        public string Kumas { get; set; }
        public override void OzellikYaz()
        {
            Console.WriteLine("Koltuk Özellikleri: ");
            Console.WriteLine("------------------------");
            Console.WriteLine("Renk: {0}", Renk);
            Console.WriteLine("Kumaş: {0}", Kumas);
        }
    }
}

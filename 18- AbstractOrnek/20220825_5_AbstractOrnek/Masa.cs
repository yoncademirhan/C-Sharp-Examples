using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220825_5_AbstractOrnek
{
    public class Masa : Mobilya
    {
        public string Malzeme { get; set; }

        public override void OzellikYaz()
        {
            Console.WriteLine("Masanın Özellikleri:");
            Console.WriteLine("---------------------");
            Console.WriteLine("Renk: {0}", Renk);
            Console.WriteLine("Malzeme: {0}", Malzeme);
        }
    }
}

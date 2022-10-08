using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(topla(2, 3, 5, 4, 8, 6, 7));

            Console.ReadLine();

           // return 0;
            
        }

        static int topla(params int[] sayilar)
        {
            int toplam = 0;

            foreach (var item in sayilar)
            {
                toplam += item;
            }

            return toplam;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Topla(4.5, 8.1);


            Console.ReadKey();
        }

        static void Topla(int s1, int s2)
        {
            Console.WriteLine("Toplam: " + (s1+ s2));
        }

        static void Topla(double s1, double s2)
        {
            Console.WriteLine("Toplam: " + (s1 + s2));
        }
    }
}

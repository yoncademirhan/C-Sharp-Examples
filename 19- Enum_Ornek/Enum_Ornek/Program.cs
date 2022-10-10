using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Ornek
{
    internal class Program
    {

        enum gunler
        {
            Pazartesi= 1, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar              //eğer pazartesi 1 değeri verilmez ise enumlarda ilk değer sıfır(0) kabul edilir. sanraki değerler 1 er artarak devam eder.
        }
        static void Main(string[] args)
        {
            int sayi = (int)gunler.Persembe;
            Console.WriteLine(sayi + ".gündür");



            Console.ReadKey();

        }
    }
}

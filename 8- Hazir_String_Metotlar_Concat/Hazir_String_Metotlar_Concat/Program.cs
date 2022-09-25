using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazir_String_Metotlar_Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concat: Parantez içinde yazılan verileri/ değişkenleri string veri türünde birleştirme işlemi yapar. Birleştiirlecek veriler string olmak zorunde değildir.

            string tcNo = "12458545788";
            string ad = "Ahmet";
            string soyAd = "Kaya";
            double maas = 3000;
            int cocukSayisi = 4;

            string birlestirilenVeri= string.Concat(tcNo + " " +  ad + " " + soyAd + " " + maas + " " + cocukSayisi);
            Console.WriteLine(birlestirilenVeri);

            Console.ReadKey();

        }
    }
}

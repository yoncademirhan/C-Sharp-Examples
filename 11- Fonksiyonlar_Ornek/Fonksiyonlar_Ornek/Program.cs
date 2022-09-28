using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan iki adet sayı talep edelim.
            // Sayıların toplamını metod ile alalım ve ekrana yazdıralım.
            // Geriye dönüşü olmayan parametre alan metod yazabilirsiniz.

            //Console.Write("1. sayıyı giriniz: ");
            //int sayi1 = int.Parse(Console.ReadLine());
            int sayi1 = SayiIste("1. sayıyı giriniz: ");

            //Console.Write("2. sayıyı giriniz: ");
            //int sayi2 = int.Parse(Console.ReadLine());
            int sayi2 = SayiIste("2. sayıyı giriniz: ");

            SayilariTopla(sayi1, sayi2);

            Console.ReadKey();
        }

        static int SayiIste(string metin)
        {
            //Console.Write(metin);
            //return int.Parse(Console.ReadLine());
            int deger = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    deger = int.Parse(Console.ReadLine());
                    hata = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    hata = true;
                }
            } while (hata);
            return deger;
        }

        static void SayilariTopla(int s1, int s2)
        {
            Console.WriteLine("Sayıların Toplamı: " + (s1 + s2));
        }
    }
    }
}

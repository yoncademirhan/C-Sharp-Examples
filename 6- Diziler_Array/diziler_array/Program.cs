using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örnek: İçerisinde 5 adet string değer barındıran bir dizi oluşturulaım.
            //Çözüm:

             string[] metinler = new string[5];
             metinler[1] = "selam";
             metinler[3] = "Nasılsın";
             metinler[0] = "C# Dersleri";

             Console.WriteLine(metinler[0]);
             Console.WriteLine(metinler[1]);

             Console.WriteLine(metinler[1] + " " + metinler[3]);
             Console.WriteLine();

             //dizi içerisindeki tüm elemanları ekrana yazdırmak için for döngüsü kullanılabişlir.

             for (int i = 0; i < metinler.Length; i++)
             {
                 Console.WriteLine(metinler[i]);
             }

            //Örnek: //Kullanıcdan 5 det sayı talep edelim. Talep edilen sayıları bir dizi içerisine aktaralım. Dizi içerisindeki elemanların toplamını ve ortalamsını ekrana yazdıralım.
            //Çözüm:

            int[] sayilar = new int[5];
           
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayıları giriniz:" );
                int dizi = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = dizi;

            }
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            Console.Write("Toplma: "+ toplam + "Sayıların ortalaması: " + (toplam /5));

            //2.yol
            int[] sayilar = new int[5];

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.Write((i+1) + ".sayıyı giriniz: " );
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            for(int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            Console.WriteLine("Sayıların toplamı: "+ toplam);
            Console.WriteLine("Sayıların Ortalamsı "+ ((double)toplam / sayilar.Length));



            Console.ReadKey();





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Ornek_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Örnek : Kulllanıcdan klavyeden 2 adet sayı girmesi isteniyor. 
            //Bu sayılarla yapmak istediği işlemleri belirleyecek. (+, -, *, /),
            //Metotlar kullnılarak yapılacak.


            BASADON:
            Console.WriteLine("1. Sayıyı giriniz: ");
            double sayi1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. Sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            DORTISLEMSEC:
            Console.WriteLine("Seçiminizi Yapınız: (Toplama:1 Çıkarma:2 Bölme:3 Çarpma: 4");
            char dortislemsec= Convert.ToChar(Console.ReadLine()); ;

            switch (dortislemsec)
            {
                case '1':
                    dortislem toplamaislemi = new dortislem();       //static olmadıgı için sınıftan nesne üretildi. dortislem sınıf özellikleri toplama islemine aktarıldı.
                    double toplam = toplamaislemi.topla(sayi1 , sayi2);
                    Console.Write("Toplam sonucu:{0}", toplam);
                    break;

                case '2':
                    dortislem cikarmaislemi = new dortislem();       //static olmadıgı için sınıftan nesne üretildi. dortislem sınıf özellikleri çıkarma islemine aktarıldı.
                    double fark = cikarmaislemi.topla(sayi1, sayi2);
                    Console.Write("Çıkarma sonucu:{0}", fark);
                    break;

                case '3':
                    dortislem bolmeislemi = new dortislem();       //static olmadıgı için sınıftan nesne üretildi. dortislem sınıf özellikleri bölme islemine aktarıldı.
                    double bolum = bolmeislemi.topla(sayi1, sayi2);
                    Console.Write("Bölüm sonucu:{0}", bolum);
                    break;

                case '4':
                    dortislem carpmaislemi = new dortislem();       //static olmadıgı için sınıftan nesne üretildi. dortislem sınıf özellikleri carpma islemine aktarıldı.
                    double carpım = carpmaislemi.topla(sayi1, sayi2);
                    Console.Write("Çarpım sonucu:{0}", carpım);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız, Tekrar Deneyiniz.");
                    goto DORTISLEMSEC;

            }

            DEVAMSECIM:
            Console.WriteLine("Tekrar İşlem Yapmak İster Misiniz? (Evet: E HAYIR: H)");
            char devamsec=Convert.ToChar(Console.ReadLine());

            if(devamsec == 'E' || devamsec == 'e')
            {
                Console.Clear ();
                goto BASADON;
            }
            else if(devamsec == 'H' || devamsec == 'h')
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("Yanlış seçim Yaptınız, Tekrar Deneyiniz.");
                goto DEVAMSECIM;
            }


            Console.ReadKey();


        }

        class dortislem
        {
            public double topla(double s1, double s2)
            {
                return (s1 + s2);
            }

            public double cikart(double s1, double s2)
            {
                return (s1 - s2);
            }

            public double bol(double s1, double s2)
            {
                return (s1 / s2);
            }

            public double carp(double s1, double s2)
            {
                return (s1 * s2);
            }

        }



    }
}

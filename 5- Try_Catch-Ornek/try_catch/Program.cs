using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TRy- Catch (Hata Kontrol Mekanizması)
            /*
             * *Yaznış oldugumuz kod blokalrında hataların öçnüne geçmek için kullanılan yapıdır. Hataların önüne gecmekten kasıt hataların önlenmesi değil, oluşabilecek
              hataları yakalayıp uygulamaya hata verdirmemektir.
            *Exception: Try bloğu içerisinde hata oluştugunda neden, ne için hata oluştugunun bilgisinin tutuldugu özel bir sınıftır
            *.Bu sınıf içerisinde bulunan Message property si ile hata mesajına ulaşbilirsiniz.
            */

            //Örnek: 

            int sayi = 0;
            try
            {
                sayi = int.Parse("abc");
                Console.WriteLine("Sayı :" +sayi);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);  //hata mesajını kendimiz de belirleyebilirz.
            }


            //Örnek: Kullanıcıdan iki sayı girmesini talep edelim. Kullanıcı geçersiz bir değer girdiğinde hata mesajı yazdırıp girilen sayıyı 0 olarak kabul edelim.
            //sayıların toplamını ekrana yazdıralım.

            //Çözüm:

             int sayii, sayiii;

             Console.Write("1. sayıyı giriniz: ");
             try
             {
                 sayii= int.Parse(Console.ReadLine());
             }
             catch(Exception e)
             {
                 Console.WriteLine("Geçersiz bir değer girdiniz.");
                 Console.WriteLine("Girilen sayıyı 0(sıfır) olarak tanımlıyorum.");
                 sayii = 0;
             }


             Console.Write("2. sayıyı giriniz: ");
             try
             {
                 sayiii = int.Parse(Console.ReadLine());
             }
             catch (Exception e)
             {
                 Console.WriteLine("Geçersiz bir değer girdiniz.");
                 Console.WriteLine("Girilen sayıyı 0(sıfır) olarak tanımlıyorum.");
                 sayiii = 0;
             }

             Console.WriteLine();
             Console.WriteLine("Sayıların Toplamı: " + (sayii + sayiii)); 



            //Örnek: Kullanıcıdan bir adet sayı talep edelim. Kullanıcı doğru deger girene kadar aynı sayı tekrar tekrar talep edelim.
            //Doğru sayı girdiğinde ise "Girilen sayı: <sayı> şeklinde ekrana yazdıralm.

            //Çözüm:


            int sayi4 = 0;
            bool hata1;
            do
            {
                Console.Write("Bir sayı giriniz: ");
                try
                {
                    sayi4 = int.Parse(Console.ReadLine());
                    hata1 = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Geçerli bir formatta sayı giriniz: ");
                    hata1 = true;
                }
            }while (hata1);

            Console.WriteLine("Girilen sayı : "+ sayi4);  




            //Örnek: Kullanıcdan 3 adet sayı talep edelim. Girilen sayıların toplamı ve ortalamasını ekrana yazdıralım.
            //Not: Kullanıcı doğru deger girene kadar tekrar deger istensin.

            //Çözüm:

            int sayi1=0, sayi2=0, sayi3=0;
            bool hata = false;
            

            do
            {
                Console.Write("1. sayıyı giriniz");
                
                try
                {
                  sayi1 = int.Parse(Console.ReadLine());
                    hata = false;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Gecersiz bir deger girdiniz.");
                    hata = true;
                }
            }while(hata);
            do
            {
                Console.Write("2. sayıyı giriniz");

                try
                {
                    sayi2 = int.Parse(Console.ReadLine());
                    hata = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Gecersiz bir deger girdiniz.");
                    hata = true;
                }
            } while (hata);

            do
            {
                Console.Write("3. sayıyı giriniz");

                try
                {
                    sayi3 = int.Parse(Console.ReadLine());
                    hata = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Gecersiz bir deger girdiniz.");
                    hata = true;
                }
            } while (hata);

            int toplam = sayi1 + sayi2 + sayi3;
            double ortalama = (sayi1 + sayi2 + sayi3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("SAyıların ortalaması: " + ortalama);


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__do_while_Dongu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  do
              {
                  komutlaar en az 1 efa çalıştırılır.
              }while(şart ya da şartlar);  //while içinde şart sağlanıyorsa do çalışmaya devam eder. */

            //******ÖRNEK- 1- *****
            int sayac = 1;

            do
            {
                Console.WriteLine(sayac);
                sayac++;
            } while (sayac <=5);

            Console.ReadKey();


            //****ÖRNEK- 2- ******
            //sistemde verilen kullanıcı ad ve şifrenin kullanıcı tarafından girilen bilgilerle uyuşp uyuşmadıgını kontrol edelim.

            string kad = "admin", ksifre = "123";
            string kullaniciad, kullanicisifre;
            int hak = 3;

            do
            {
                Console.WriteLine("Kullanıcı adını giriniz: ");
                kullaniciad = Console.ReadLine();

                Console.WriteLine("şifre giriniz: ");
                kullanicisifre = Console.ReadLine();

                if(kullaniciad== kad && kullanicisifre== ksifre){
                    Console.WriteLine("Hoşgeldiniz");
                }
                else
                {
                    hak--;
                    if (hak == 0)
                    {
                        Console.WriteLine("3 defa dogru kullanıcı adı ve şifre giremediniz. Müşteri hizmetlerini Arayınız.");
                    }
                }
            } while ((kullaniciad !=kad || kullanicisifre != ksifre) && hak !=0);   //sonuc true dönerse kullanıcıya yeni hak verilir.


            Console.ReadKey();


        }
    }
}

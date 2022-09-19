using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıf_Esle_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdanbir adet syı talep edelim
            //girilen sayı tek mi çift mi ekrana yazdıralım.

            Console.WriteLine("Sayı girniz: ");
             int s1 = Convert.ToInt32(Console.ReadLine());

             if(s1 % 2==0)
             {
                 Console.WriteLine("Girdiğiniz saytı çifttir.");

                 }
             else
             {
                 Console.WriteLine("Girdiğiniz sayı tektir.");
             }


            //Örnek
            //Kullanıcıdan üç adet not bilgisi talep edelim
            //Girilen notların ortalamsıo 50 ve üzeri ise geçti değilse kaldı

            Console.WriteLine("1. Sınav notu giriniz: ");
            double not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sınav notu giriniz: ");
            double not2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. Sınav notu giriniz: ");
            int not3 = Convert.ToInt32(Console.ReadLine());

            double ortalama = (not1+not2+ not3)/3;  //int değerler 3.0 ile bölünürse double sonuc cıkar.
           // double ortalama =(double) (not1 + not2 + not3) / 3;   // bu yömtemlede bilinçli tür dönüşümü yapılabilir.

            if (ortalama >= 50)
            {
                Console.WriteLine("Ders ortalamanız: "+ortalama +" Dersten geçtiniz");
            }
            else
            {
                Console.WriteLine("Ders ortalamanız: " + ortalama+ " Dersten kaldınız");
            }



            //ÖRNEK:
            //Kullanıcıdan 2 adet sayı ve bir adet işlem türü talep edelim
            //İşlem türüne göre matematşksel işlemi yapıp ekrana sonucu tadıralım
            //İşlem türleri(+,-,*,/) ibaret olamlıdır. başka değer girdiğnde kabul etmemmeliyiz
            //Ekran cıktısı: 5+8= 13 şeklinde olmalıdır.

            Console.WriteLine("1.Sayı girniz: ");
             int sayi1 = int.Parse(Console.ReadLine());

             Console.WriteLine("2.Sayı girniz: ");
             int sayi2 = int.Parse(Console.ReadLine());

             Console.WriteLine("İşlem türü giriniz:(+,-,*,/) ");
             string IslemTuru = (Console.ReadLine());

             if(IslemTuru == "+")
             {
                 Console.WriteLine(sayi1+ " "+ IslemTuru+ " "+ sayi2+ "= " + (sayi1+ sayi2 ));
             }
             else if(IslemTuru == "-")
             {
                 Console.WriteLine("{0} {1} {2} = {3}", sayi1, IslemTuru, sayi2, (sayi1 - sayi2));
             }
             else if (IslemTuru == "*")
             {
                 Console.WriteLine("{0} {1} {2} = {3}", sayi1, IslemTuru, sayi2, (sayi1 * sayi2));
             }
             else if (IslemTuru == "/")
             {
                 Console.WriteLine("{0} {1} {2} = {3}", sayi1, IslemTuru, sayi2, (sayi1 / sayi2));
             }
             else
             {
                 Console.WriteLine("Geçerli bir işlem girmediniz");
             }
            



            //ÖRNEK
            //Kullanıcıdan kullanıcı adı ve parola bilgisi talep edelim
            //Sistemde kayıtlı olan bilgilerle eşleşiyorsa "Giriş Yaptınız.", eşleşmiyorsa kullanıcı adı veya parola gecersiz mesaj yazdıralım
            //string kAdi= "aytac", parola = "123456";

            //ÇÖZÜM

            string kAdi = "aytac";
            string  parola = "123456";

            Console.WriteLine("Kullanıcı adı giriniz: ");
            string kAdi1 = (Console.ReadLine());

            Console.WriteLine("Parola giriniz: ");
            string parola1 = (Console.ReadLine());


            if(kAdi == kAdi1 && parola1 == parola)
            {
                Console.WriteLine("Giriş yaptınız");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya parola gecersiz.");
            }






        }
    }
}

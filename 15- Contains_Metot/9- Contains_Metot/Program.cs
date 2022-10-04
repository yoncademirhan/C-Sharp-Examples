using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9__Contains_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONTAINS: koleksiyonda bulunan verilerin, belirlenen koşula göre olup olmadığını kontrol eder.Aranılan ifade eger metin içeriisnde var ise TRUE döner.

            string ad, soyad;
            bool arama_ad, arama_soyad;

            Console.WriteLine("Adınızı Giriniz: ");
            ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz: ");
            soyad = Console.ReadLine();

            arama_ad = rakamara(ad);   //ad değişkeninin içinde arakam aranacak ve arama sonucu arama_ad değişkenine aktarılır.

            arama_soyad = rakamara(soyad);

            if (arama_ad == true)            //arama_ad işlemi sonucunda rakama rastlanıldıysa;
            {
                Console.WriteLine("Ad içerisinde rakam kullanılmamalı !");
            }

            if (arama_soyad == true)
            {
                Console.WriteLine("Soyad içerisinde rakam kullanılmamalı !");
            }

            if (arama_ad == false && arama_soyad == false)
            {
                Console.WriteLine("Kayıt İşlemi başarı ile tamamlanmıştır.");

            }

            Console.ReadKey();
        }


        public static bool rakamara(string aranacakmetin)
        {
            if (aranacakmetin.Contains('0') == true)             //aranacak metin içinde sıfır(0) degeri var mı ?
            {
                return true;
            }
            else if (aranacakmetin.Contains('1') == true)
            {
                return true;
            }
            else if (aranacakmetin.Contains('2') == true)
            {
                return true;
            }

            else if (aranacakmetin.Contains('3') == true)
            {
                return true;
            }

            else if (aranacakmetin.Contains('6') == true)
            {
                return true;
            }

            else if (aranacakmetin.Contains('7') == true)
            {
                return true;
            }

            else if (aranacakmetin.Contains('8') == true)
            {
                return true;
            }

            else if (aranacakmetin.Contains('9') == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazir_String_Metotlar_IsNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IsNullOrEmpty: string türündeki br değişkene değer atanıp atanmadıgını kontrol etmek için kullanılır. eğer değişkenin değeri mevcut ise FALSE değeri döner. Mevcut değilse TRUE döner.

            string ogrno, ad, soyad;
            Console.WriteLine("Öğrenci Numaranızı giriniz: ");
            ogrno = Console.ReadLine();

            Console.WriteLine("Adınızı giriniz: ");
            ad = Console.ReadLine();


            Console.WriteLine("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();


            if (string.IsNullOrEmpty(ogrno) == true)                //Kontrol etmek istenilen değişken parantez içine yazdırlır.
            {
                Console.WriteLine("Öğrenci Numaranızı boş Geçemezsiniz");
            }

            if (string.IsNullOrEmpty(ad) == true)
            {
                Console.WriteLine("Adınızı boş Geçemezsiniz");
            }

            if (string.IsNullOrEmpty(soyad) == true)
            {
                Console.WriteLine("Soyadınızı boş Geçemezsiniz");
            }

            if (string.IsNullOrEmpty(ogrno) == false && string.IsNullOrEmpty(ad) == false && string.IsNullOrEmpty(soyad) == false)         //değişkenlere veri girildiyse sorgusu kullanılır.
            {
                Console.WriteLine("Kayıt İşlemi Başarı ile Tamamlanmıştır.");
            }


            Console.ReadKey();





        }
    }
}

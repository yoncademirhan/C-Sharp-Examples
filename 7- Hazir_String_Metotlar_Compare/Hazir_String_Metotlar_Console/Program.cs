using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazir_String_Metotlar_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Compare: String deger arasında karsılaştrıma yapmamızı sağlar. Eger aynı degerler ise sıfır(0) , değilse 1 değeri döndürür.

            int karsilastirma = String.Compare("admin", "admin");
            Console.WriteLine(karsilastirma);                       //string degerler aynı oldugu için 0 degeri döndürür.


            int karsilastirma2 = String.Compare("adminn", "admin");
            Console.WriteLine(karsilastirma2);                      //string degerler aynı olmadığı için 1 degeri döndürür.


            //Örnek: Kullanıcıdan Kullnaıcı adı ve şifre isterek doğrulugunu kontrol etme

            Console.WriteLine("Kullanıcı adı belirleyiniz: ");
            string kullaniciAdi= Console.ReadLine();

            SIFREBELIRLE:
            Console.WriteLine("Şifrenizi Belirleyiniz: ");
            string sifre1= Console.ReadLine();

            Console.WriteLine("Şifrenizi Tekrar Giriniz: ");
            string sifre2 = Console.ReadLine();

            int kontrol = string.Compare(sifre1, sifre2, false);    //Girilen 3. deger olan false ile küçük-büyük harf duyarlılıgı olması belirtildi. eger true olsaydı duyarlılık olmazdı.

            if(kontrol == 0)
            {
                string sifre = sifre1;
                Console.WriteLine("Kayıt İşlemi Başarılı Bir şekilde Tamamlanmıştır. Kullnaıcı Adı: {0} Şifre {1}", kullaniciAdi, sifre);
            }
            else
            {
                Console.WriteLine("Girilen Şifreler Aynı değildir.");
                goto SIFREBELIRLE;
            }





            Console.ReadKey();
        }
    }
}

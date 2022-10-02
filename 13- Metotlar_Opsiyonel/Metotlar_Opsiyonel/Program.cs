using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar_Opsiyonel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayı giriniz: ");
            int sayi1 =int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayı giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("İşlem türünü giriniz(+, -, *, /): ");
            char tur = char.Parse(Console.ReadLine());

            islem(sayi1, sayi2, tur);



            Console.ReadKey();

            Console.ReadLine();
        }
        //Kullanıcıdan iki adet sayı ve bir işlem türü talep edelim.
        //dört işleme bağlı olarak soınucu ekrana yazdıralım
        //İşlemi fonksiyon ile yapınız.
        

        private static void islem(int s1,int s2, char tur)
        {
            double sonuc = 0;
            bool hata = false;
            switch (tur)
            {
                case '+': sonuc = s1 + s2; break;
                case '-': sonuc = s1 - s2; break;
                case '*': sonuc = s1 * s2; break;
                case '/': sonuc = s1 / s2; break;
                default:
                    Console.WriteLine("Geçerli bir işlem türü giriniz:");
                    hata = true;
                    break;

            }
            if(!hata) //hata == false
                Console.WriteLine($"{s1} {tur} {s2} = {sonuc}");
        }
    }
}

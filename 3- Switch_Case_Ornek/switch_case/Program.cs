using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ÖRNEK
            //Klavyeden girilen sayının hangi güne ait oldugunu bulalım

            Console.WriteLine("1-7 arasında bir değer giriniz: ");
            int gun = int.Parse(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi"); break;
                case 2:
                    Console.WriteLine("Salı"); break;
                case 3:
                    Console.WriteLine("Çarşamba"); break;
                case 4:
                    Console.WriteLine("Perşembe"); break;
                case 5:
                    Console.WriteLine("Cuma"); break;
                case 6:
                    Console.WriteLine("Cumartesi"); break;
                case 7:
                    Console.WriteLine("Pazar"); break;
                default:
                    Console.WriteLine("1-7 arasında değer girmediniz."); break;


                    //ÖRNEK
                    //Kullanıcıdan 1-12 arasında bir değer girilmesini isteyin .
                    //ay adını ekrana yazdıralım.

                    //Çözüm

                    Console.WriteLine("1-2 arasında bir değer giriniz: ");
                    int ay1 = int.Parse(Console.ReadLine());

                    switch (ay1)
                    {
                        case 1:
                            Console.WriteLine("Ocak"); break;

                        case 2:
                            Console.WriteLine("Şubat"); break;

                        case 3:
                            Console.WriteLine("Mart"); break;

                        case 4:
                            Console.WriteLine("Nisan"); break;

                        case 5:
                            Console.WriteLine("Mayıs"); break;

                        case 6:
                            Console.WriteLine("Haziran"); break;

                        case 7:
                            Console.WriteLine("Temmuz"); break;

                        case 8:
                            Console.WriteLine("Ağustos"); break;

                        case 9:
                            Console.WriteLine("Eylül"); break;

                        case 10:
                            Console.WriteLine("Ekim"); break;

                        case 111:
                            Console.WriteLine("Kasım"); break;

                        case 12:
                            Console.WriteLine("Aralık"); break;
                        default:
                            Console.WriteLine("1-12 arasında değer girmelisiniz."); break;

                    }



                    //ÖRNEK

                    Console.WriteLine("1-2 arasında bir değer giriniz: ");
                    int ay = int.Parse(Console.ReadLine());

                    switch (ay)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("Kış");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("İlkBahar");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Yaz");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Sonbahar");
                            break;
                    }


                    //Örnek: kullanıcıdan 2 adet ssayı ve bir adet işlem türü talep edelim. hesaplama yapalım

                    Console.Write("1. sayı değerini giriniz :");
                    int sayi1 = int.Parse(Console.ReadLine());


                    Console.Write("2. sayı değerini giriniz :");
                    int sayi2 = int.Parse(Console.ReadLine());

                    Console.Write("İşlemi giriniz: +,-,*,/");
                    string islem = Console.ReadLine();


                    string metin = "{0} {1} {2} = {3}";
                    double sonuc = 0;

                    switch (islem)
                    {
                        case "+":
                            sonuc = sayi1 + sayi2; break;

                        case "-":
                            sonuc = sayi1 - sayi2; break;
                        case "*":
                            sonuc = sayi1 * sayi2; break;
                        case "/":
                            sonuc = sayi1 / sayi2; break;
                        default:
                            break;
                    }

                    Console.WriteLine(string.Format(metin, sayi1, islem, sayi2, sonuc));



                    //Örnek: Bugün hafta içi mi haftasonu mu ?
                    //Çözüm:

                    switch (DateTime.Now.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                        case DayOfWeek.Tuesday:
                        case DayOfWeek.Wednesday:
                        case DayOfWeek.Thursday:
                        case DayOfWeek.Friday:

                            Console.WriteLine("Haftaiçi");
                            break;
                        case DayOfWeek.Saturday:
                        case DayOfWeek.Sunday:
                            Console.WriteLine("Haftasonu");
                            break;

                    }


                    Console.ReadKey();



            }

        }
    }

}


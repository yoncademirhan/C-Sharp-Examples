using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAteTimeAndTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime tarih = DateTime.Now;
            Console.WriteLine("Şimdikği zaman: " + tarih);
            Console.WriteLine("Tarih bilgisi: " + tarih.Date);
            Console.WriteLine("Gün Bilgisi: "+ tarih.Day);
            Console.WriteLine("Ay Bilgisi: " + tarih.Month);
            Console.WriteLine("Yıl Bilgisi: " + tarih.Year);
            Console.WriteLine("haftanın kaçıncı günü : " + tarih.DayOfWeek);
            Console.WriteLine("yılınkaçıncı günü:" + tarih.DayOfYear);
            Console.WriteLine("saat bilgisi :" + tarih.Hour);
            Console.WriteLine("dakika bilgisi :" + tarih.Minute);
            Console.WriteLine("saniye bilgisi :" + tarih.Second);
            Console.WriteLine("milisaniye bilgisi :" + tarih.Millisecond);


            //Custom tarih oluşturma:
            DateTime tarih2 = new DateTime(2021, 2, 15, 15, 42, 58);
            Console.WriteLine("Custom tarih :" + tarih2);

            //String olarak girilen tarih bilgisii tür dönüşümüe almak
            //1. Yöntem
            DateTime tarih3 = Convert.ToDateTime("10.05.2021 14:48:19");
            Console.WriteLine("Döüşüm Tarih: " + tarih3);
            Console.WriteLine("Dönüşüm Saat Bilgisi Bilgisi: " + tarih3.Hour);


            //2.Yöntem
            DateTime tarih4 = DateTime.Parse("09.03.2000 18:32:16");
            Console.WriteLine("Döüşüm Tarih: " + tarih4);
            Console.WriteLine("Dönüşüm Saat Bilgisi Bilgisi: " + tarih4.Hour);



            Console.WriteLine();



            Console.WriteLine("1 Yıl Ekle: " + tarih.AddYears(1));  //1 yıl ileri tarih yazdırır.

            Console.WriteLine("1 Yıl Ekle: " + tarih.AddYears(-1)); //1 yıl geri yazdırır.
            Console.WriteLine("7 ay ekle: " + tarih.AddMonths(7));
            Console.WriteLine("45 gün ekle : " + tarih.AddDays(45));
            Console.WriteLine("15 saat ekle: " + tarih.AddHours(15));



            Console.WriteLine();



            Console.WriteLine("Uzun Tarih Bilgisi:" + tarih.ToLongDateString());   //uzun tyarih bilgisi verir.

            Console.WriteLine("Kısa Tarih Bilgisi:" + tarih.ToShortDateString());  //kısa tariih bilgisi verir.

            Console.WriteLine("Uzun Saat Bilgisi:" + tarih.ToLongTimeString());  //uzun saat bilgisinde saniye bilgisi de verir.

            Console.WriteLine("Kısa Saat Bilgisi:" + tarih.ToShortTimeString());  //kısa saaat bilgisinde saat ve dk yazdırır.

            //Tarih ve saat gösterim formatları
            //Tek karakterli formatlar

            Console.WriteLine("d=> " + tarih.ToString("d"));
            Console.WriteLine("D =>" + tarih.ToString("D"));
            Console.WriteLine("f =>" + tarih.ToString("f"));
            Console.WriteLine("F=>" + tarih.ToString("F"));
            Console.WriteLine("g =>" + tarih.ToString("g"));
            Console.WriteLine("G =>" + tarih.ToString("G"));
            Console.WriteLine("m =>" + tarih.ToString("m"));
            Console.WriteLine("M =>" + tarih.ToString("M"));
            Console.WriteLine("o =>" + tarih.ToString("o"));
            Console.WriteLine("O=>" + tarih.ToString("O"));
            Console.WriteLine("s =>" + tarih.ToString("s"));
            Console.WriteLine("t =>" + tarih.ToString("t"));
            Console.WriteLine("T =>" + tarih.ToString("T"));
            Console.WriteLine("u=>" + tarih.ToString("u"));
            Console.WriteLine("U =>" + tarih.ToString("U"));
            Console.WriteLine("y =>" + tarih.ToString("y"));
            Console.WriteLine("Y =>" + tarih.ToString("Y"));

            Console.WriteLine();



            // Kullanılabilecek diğer DateTime formatları:

            Console.WriteLine("MMMM=> " + tarih.ToString("MMMM"));  //ay bilgisini tam verir.
            Console.WriteLine("MMM => " + tarih.ToString("MMM"));  //3 karakterli ay bilgisi verir.
            Console.WriteLine("MM => " + tarih.ToString("MM"));
            Console.WriteLine("dddd => " + tarih.ToString("dddd"));  //gün bilgisini tam verişr.
            Console.WriteLine("ddd => " + tarih.ToString("ddd"));  //gün bilgisi 2 karakter verir . 07 gibi
            Console.WriteLine("dd => " + tarih.ToString("dd"));
            Console.WriteLine("yyyy => " + tarih.ToString("yyyy")); //4 karakterli yıl bilgisi verir.
            Console.WriteLine("yy => " + tarih.ToString("yy"));
            Console.WriteLine("HH => " + tarih.ToString("HH"));  //24 saatlik dilimde ssat bilgisi verir.
            Console.WriteLine("hh => " + tarih.ToString("hh"));  //12saatlik dilimde ssat bilgisi verir.
            Console.WriteLine("mm => " + tarih.ToString("mm"));  //dakika bilgisi verir.
            Console.WriteLine("ss => " + tarih.ToString("ss"));   //saniye bilgisi verir.


            Console.WriteLine("Özel Tarih Biçimi: " + tarih.ToString("yyyy MMMM dd dddd"));

            Console.WriteLine("Özel Tarih Biçimi: " + tarih.ToString("dddd dd MMMM yyyy"));

            Console.WriteLine();


            Console.WriteLine("TimeSpan");
            Console.WriteLine("------------");
            //Vermiş oldugumuz iki tarih arasındaki gün sayısını DateTime.Subtract() methodu ile hesaplarız.
            //Bu method bize geriye TimeSpan formatında bir dönüş sağlamaktadır.
            //Syntax
            //TimeSpan <degiskenAdi> = <ikincitarih>.Subtrcat(<ilkTarih>);

            //Örnek
            //--------
            //10.05.2022 tarihi ile şimdiki zaman arasındaki farkı bulalım.

            DateTime oncekiTarih= Convert.ToDateTime("10.05.2022");
            TimeSpan fark = tarih.Subtract(oncekiTarih);
            Console.WriteLine("iki tarih arasındaki gün farkı : " + fark.TotalDays);
            Console.WriteLine("iki tarih arasındaki gün saat  farkı : " + fark.TotalHours);
            Console.WriteLine("iki tarih arasındaki dakika farkı : " + fark.TotalMinutes);
            Console.WriteLine("iki tarih arasındaki saniye farkı : " + fark.TotalSeconds);
            Console.WriteLine("iki tarih arasındaki milisaniye farkı : " + fark.Milliseconds);

            Console.WriteLine();

            //Örnek Kullanıcıdan iki tarih bilgisi girmesini isteyelim
            //Girilen tarihler arasındaki gün farkını ekrana yazdıralım.
            //Çözüm
             Console.Write("1. Tarih bilgisini giriniz: ");
             DateTime tarih5 = DateTime.Parse(Console.ReadLine());     //ReadLine ,ile kullanıcıdan bilgi girmesi sağlanır.

             Console.Write("2. Tarih bilgisini giriniz: ");
             DateTime tarih6 = DateTime.Parse(Console.ReadLine());

             TimeSpan farklari =tarih5.Subtract(tarih6);
             Console.WriteLine("Gün Farkı : " + farklari.TotalDays);

            Console.WriteLine();

            //Örnek 2:
            //Kullanıcıdan Doğum Tarihi bilgisi talep edelim. Doğum tarihi girilen kişşinişn yaşının, bu zamana kadar kaç gün ve 
            //kaç saat yaşadığını ekrana yazdıralım.

            //Çözüm:
            Console.Write(" Doğum Tarihini giriniz: ");
             DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());  //kullanıcıdan alınan string tarih dönüşümü yapılır.

             DateTime SimdikiTarih = DateTime.Now;   //günümüz tarihi yazdırır.

             TimeSpan farklarii = SimdikiTarih.Subtract(dogumTarihi);
             Console.WriteLine("Yaşadığı gün :" + farklarii.TotalDays);
             Console.WriteLine("Yaşadığı saat :" + farklarii.TotalHours);
             Console.WriteLine("Yaşınız :" + farklarii.Days / 365);
















            Console.ReadKey();

        }
    }
}

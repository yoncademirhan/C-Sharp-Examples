using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220816_1_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler();

            ConsoleKey islem;
            do
            {
                Console.Clear();
                Console.WriteLine("ÖĞRENCİ KAYIT PROGRAMI");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.WriteLine("E- Öğrenci Ekle");
                Console.WriteLine("L- Öğrenci Listele");
                Console.WriteLine("A- Öğrenci Ara");
                Console.WriteLine("S- Öğrenci Sil");
                Console.WriteLine("O- Tüm Öğrencilerin Not Ortalaması");
                Console.WriteLine("ESC- Programdan Çık");

                Console.WriteLine();
                Console.Write("Hangi işlemi yapmak istersiniz: ");
                islem = Console.ReadKey().Key;

                islemler.Menu(islem);


            } while (islem != ConsoleKey.Escape);

            Console.Clear();
            Console.WriteLine("Programı kullandığınız için teşekkür ederiz.");
            Console.WriteLine("Programdan çıkmak için bir tuşa basınız.");
            Console.ReadKey();

        }
    }
}

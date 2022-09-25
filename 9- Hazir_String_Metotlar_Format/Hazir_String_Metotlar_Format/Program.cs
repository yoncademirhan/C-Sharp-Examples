using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazir_String_Metotlar_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //format ile veriler istediğimiz düzende gösterilir.

            string a1 = "11111111111";
            string a2 = "Ayşe Dağhan";
            int a3 = 2500;
            double a4 = 5055055555;

            string b1 = "22222222222";
            string b2 = "Ahmet Öztürk";
            int b3 = 3000;
            double b4 = 5446542527;

            Console.WriteLine("Tc Kimlik No | Adı Soyadı           | Maas    | Telefon No      |");     //Başlık Kısımları Oluşturuldu

            Console.WriteLine(String.Format("{0,-12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |", a1, a2, a3, a4));  //ilk yazılan deger index sırasını belirler. 
                                                                                                                          //- 20 : 20 karakterlik yer ayırır - sola dayalı veri girişi yapılmasını sağlar.

            Console.WriteLine(String.Format("{0,-12} | {1,-20} | {2:0000000} | {3:(###) ### ## ##} |", b1, b2, b3, b4));



            Console.ReadKey();

        }
    }
}

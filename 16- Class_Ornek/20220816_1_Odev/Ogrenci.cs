using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220816_1_Odev
{
    public class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public short No;
        public double N1;
        public double N2;
        public double F;

        public double Ortalama()
        {
            return (N1 + N2 + F) / 3;
        }

        internal void Yazdir(int siraNo)
        {
            Console.WriteLine($"{siraNo}. {No}\t - {Ad} {Soyad}");
        }
    }
}

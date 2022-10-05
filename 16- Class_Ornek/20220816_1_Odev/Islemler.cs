using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace _20220816_1_Odev
{
    public class Islemler
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public void Menu(ConsoleKey islem)
        {
            Console.Clear();
            switch (islem)
            {
                case ConsoleKey.E:
                    Ekle();
                    break;
                case ConsoleKey.L:
                    Listele();
                    break;
                case ConsoleKey.A:
                    Ara();
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.O:
                    break;
                default:
                    if (islem != ConsoleKey.Escape)
                        AnamenuyeDon("Geçersiz işlem bilgisi girdiniz.");
                    break;
            }
        }

        private void Ara()
        {
            Baslik("ÖĞRANCİ ARA");

            string mesaj = String.Empty;

            if (ogrenciler.Count > 0)
            {
                string ara = stringIste("Aramak istediğiniz öğrenci(ad,soyad): ");
                int adet = 0;

                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    if (ogrenciler[i].Ad.Contains(ara) || ogrenciler[i].Soyad.Contains(ara))
                    {
                        ogrenciler[i].Yazdir(i + 1);
                        adet++;
                    }
                }

                mesaj = $"{ara} kelimesi sonucu {adet} adet öğrenci bulundu.";
            }
            else
            {
                mesaj = "Arama yapabilmeniz için en az 1 öğrenci eklenmesi gerekmektedir.";
            }

            AnamenuyeDon(mesaj);
        }

        private void Listele()
        {

            Baslik("ÖĞRENCİLERİ LİSTELE");

            string mesaj = String.Empty;
            if (ogrenciler.Count > 0)
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }

                mesaj = $"{ogrenciler.Count} adet öğrenci listelenmiştir.";
            }
            else
            {
                mesaj = "Listelenecek bir öğrenci bulunamadı.";
            }

            AnamenuyeDon(mesaj);
        }

        private void Ekle()
        {
            Baslik("ÖĞRENCİ EKLE");
            Ogrenci o = new Ogrenci();
            o.Ad = stringIste("Ad: ", 3);
            o.Soyad = stringIste("Soyad: ", 2);
            o.No = shortIste("No: ");
            o.N1 = doubleIste("1. Not: ", 0, 100);
            o.N2 = doubleIste("2. Not: ", 0, 100);
            o.F = doubleIste("Final Notu: ", 0, 100);

            ogrenciler.Add(o);

            AnamenuyeDon("Öğrenci ekleme işlemi başarı ile tamamlanmıştır.");
        }

        private double doubleIste(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine().Trim());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine($"Lütfen {min} ile {max} arasında bir değer giriniz.");
                    }
                }
                catch
                {
                    hata = true;
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                }
            } while (hata);
            return sayi;
        }

        private short shortIste(string metin)
        {
            short sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = short.Parse(Console.ReadLine().Trim());
                    hata = false;
                }
                catch
                {
                    hata = true;
                    Console.WriteLine("Lütfen geçerli bir sayısal değer giriniz.");
                }
            } while (hata);
            return sayi;
        }

        string stringIste(string metin, int min = 1, int max = 20)
        {
            string deger = string.Empty;
            bool hata = false;
            do
            {
                Console.Write(metin);
                string a = Console.ReadLine().Trim();
                try
                {
                    int.Parse(a);
                    hata = true;
                    Console.WriteLine("Lütfen metin değeri giriniz.");
                }
                catch
                {
                    if (!string.IsNullOrEmpty(a))
                    {
                        if (a.Length >= min && a.Length <= max)
                        {
                            for (int i = 0; i < a.Length; i++)
                            {
                                try
                                {
                                    int.Parse(a[i].ToString());
                                    hata = true;
                                    Console.WriteLine("İsim içerisinde rakam giremezsiniz.");
                                    break;
                                }
                                catch
                                {
                                    hata = false;
                                }
                            }
                            deger = a;
                        }
                        else
                        {
                            hata = true;
                            Console.WriteLine($"Lütfen {min} ile {max} karakter aralığında bir değer giriniz.");
                        }
                    }
                    else
                    {
                        hata = true;
                        Console.WriteLine($"Lütfen bir değer giriniz.");
                    }
                }

            } while (hata);
            return deger;
        }

        private void Baslik(string metin)
        {
            Console.WriteLine(metin);
            Console.WriteLine("------------------");
            Console.WriteLine();
        }

        private void AnamenuyeDon(string metin)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(metin);
            Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}

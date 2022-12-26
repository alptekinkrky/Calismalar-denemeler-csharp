using System;

namespace MetodsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            carpmaYap(7, 7, 7); // int tipi parametreli geriye değer döndürmeyen metot

            ısımSoyısımYazdır("Alp", "Tekin"); // string tipi parametreli geriye değer döndürmeyen metot

            int sonuc = toplamaYapRe(7, 22); // int tipi parametreli geriye değer döndüren metot

            if (sonuc>50)
            {
                Console.WriteLine("sonuc 50 den büyüktür");
                
            }
            else
            {
                Console.WriteLine("sonuç 50 den küçüktür");
            }

            Console.WriteLine("Şifreyi Giriniz :");
            string sifre =Console.ReadLine();

            string loginInfo = kaydet(sifre); //string tipi parametreli geriye değer döndüren metot

            if (loginInfo=="12345")
            {
                Console.WriteLine(loginInfo + " Şifre doğru");
            }
            else
            {
                Console.WriteLine("Şifre yanlış!!!");
            }

            
            Console.ReadLine(); 

            
            
        }


        static void carpmaYap(int sayi1, int sayi2 ,int sayi3)
        {
            Console.WriteLine("Sayıların çarpımı :"+ (sayi1*sayi2*sayi3));
        }

        static void ısımSoyısımYazdır(string isim, string soyisim)
        {
            Console.WriteLine("İsim Soyisim :" + isim + " " + soyisim);
        }

        static int toplamaYapRe(int sayi1, int sayi2)
        {
            int sonuc = (sayi1 + sayi2);
            return sonuc;
        }

        static string kaydet(string sifre)
        {
            Console.WriteLine("Şifre :"+sifre);
            return sifre;
        }
    }
}

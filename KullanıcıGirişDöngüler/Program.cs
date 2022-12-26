using System;

namespace KullanıcıGirişDöngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hakSayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz");
                string kullanıcıAdi = Console.ReadLine();

                Console.WriteLine("Kullanıcı şifrenizi giriniz");
                string sifre = Console.ReadLine();

                if (kullanıcıAdi == "Ammar" && sifre =="12345")
                {
                    Console.WriteLine("Giriş başarılı tebrikler!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz hatalı");

                    if (hakSayisi>0)
                    {
                        hakSayisi -= 1;
                    }
                    if (hakSayisi==0)
                    {
                        Console.WriteLine("3 kere hatalı giriş yaptınız giriş hakkınız bitmiştir");
                        break;
                        
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

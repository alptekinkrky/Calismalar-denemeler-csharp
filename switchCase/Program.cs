using System;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mini ATM Uygulaması
            //1-Bakiye Görüntüle
            //2-Para çek
            //3-Para yatır
            //4-Çıkış yap
            //1-2-3-4 dışındaki değerler için hata ver

            int bakiye = 700;

            Console.WriteLine("ATM ye hoşgelddiniz..");

            Console.WriteLine("Lütfen bir işlem giriniz");
            Console.WriteLine("1-Bakiye Görüntüle");
            Console.WriteLine("2 Para Çek");
            Console.WriteLine("3 Para Yatır");
            Console.WriteLine("4 Çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz :" + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                    int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                    if (cekilecekTutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz :" + (bakiye - cekilecekTutar));
                        Console.ReadLine();
                    }

                    break;

                case "3":

                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                    int yatirilicakTutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni bakiyeniz :" + (yatirilicakTutar + bakiye));
                    Console.ReadLine();
                    break;

                case "4":

                    Console.WriteLine("Hesabınızdan çıkış yapılmıştır");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Hatalı giriş yaptınız");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

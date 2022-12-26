using System;

namespace Exm2Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz...");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 1; i < sayi; i++)
            {
                toplam += i;
            }

            double ortalama = toplam / sayi;

            if (ortalama > 50)
            {
                Console.WriteLine("Ortalamanız 50'den büyüktür...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ortalamanız 50'den küçüktür...");
                Console.ReadLine();
            }
        }
        
    }
}

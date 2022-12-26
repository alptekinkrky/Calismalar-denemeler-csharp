using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayilar dizisinin "+ (i+0) +". indexisini giriniz: ");

                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*******************");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}

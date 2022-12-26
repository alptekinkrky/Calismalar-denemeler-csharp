using System;

namespace DizilerExm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            string urunKod;



            string[] depoUrunler = {"42nN","42nN","41nN","38nN","36nN","40nA","36nA","36nS","44nS","41nS", "42nN", "41nN", "38nN", "36nN", "40nA", "36nA", "36nS", "44nS", "41nS", "42nN", "41nN", "38nN", "36nN", "40nA", "36nA", "36nS", "44nS", "41nS", "42nN", "41nN", "38nN", "36nN", "40nA", "36nA", "36nS", "44nS", "41nS", "42nN", "41nN", "38nN", "36nN", "40nA", "36nA", "36nS", "44nS", "41nS", "42nN", "41nN", "38nN", "36nN", "40nA", "36nA", "36nS", "44nS", "41nS"};

            Console.WriteLine("Lütfen ürün kodu giriniz: ");

            urunKod = Console.ReadLine();

            for (int i = 0; i < depoUrunler.Length; i++)
            {
                if (urunKod == depoUrunler[i])
                {
                    adet++;
                }
            }

            if (adet==0)
            {
                Console.WriteLine("Aradığınız ürün depoda bulunamadı!");
            }
            else
            {
                Console.WriteLine("Aradığınız ürün depoda vardır");
                Console.WriteLine("Adet: " + adet);
            }
            Console.ReadLine();
        }

    }
}

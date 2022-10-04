using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değer ve Referans tipleri;
            //int, decimoş, float, double, bool(0, 1) = değer tipleri
            //array; class, interface = referans tipi
            //stack değer tipi   ---- heap referans tip
            //değer tiplerde değeri atıyorsun,  referans tiplerde adresi atıyorsun
            
                
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1= sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] {10, 20, 30};
            int[] sayilar2 = new int[] {100, 200, 300}; 
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar2[0]);


        }
    }
}

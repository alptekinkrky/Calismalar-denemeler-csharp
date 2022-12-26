using System;

namespace BedenKitleIndexi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuz giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bki = kilo / (boy * boy);

            if (bki < 18)
            {
                Console.WriteLine("Zayıfsın");
            }
            else if (bki > 18 && bki < 25)
            {
                Console.WriteLine("NORMAL");
            }
            

            else if(bki > 25)
            {
                Console.WriteLine("OBEZsin");
            }


        }
    }
}


using System;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");  
            }

            Console.WriteLine("-----------------Metodlar------------------");
      
            //encapsulation


            SepetManager sepetManeger = new SepetManager();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);

            sepetManeger.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManeger.Ekle2("Elma", "Yeşil Elma", 15, 2);
            sepetManeger.Ekle2("Karpuz", "Di karpuz", 20, 4);


        }
    }
}

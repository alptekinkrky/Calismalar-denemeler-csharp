using System;

namespace ERPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rapor çıktısı kaydı 
            Console.WriteLine("Görevli sayısını giriniz"); //görevli isimleri, görevleri
            string görevliSayısı = Console.ReadLine();
            
            Console.WriteLine("Sipariş miktarı"); // sipariş süresi
            string siparisMiktarı = Console.ReadLine();

            int toplamSiparis = Convert.ToInt32(siparisMiktarı);
            double toplam = 0;
            double ortalamaUretimSuresi;

            for (int i = 0; i < toplamSiparis; i++)
            {
                Console.WriteLine("ürün üretim süresini  giriniz");
                string uretimSuresi = Console.ReadLine();
                double urunSure = Convert.ToDouble(uretimSuresi);

                toplam += urunSure;

            }

            Console.WriteLine("toplam üretim süresi = " + toplam);

            ortalamaUretimSuresi=toplam/toplamSiparis;
            Console.WriteLine("Ortalama üretim süresi=" + ortalamaUretimSuresi);

            Console.ReadLine();

            



            /*
            Console.WriteLine("ürün üretim süresini  giriniz");
            string urunUretimSuresi = Console.ReadLine();
            Console.WriteLine("ürün süresini  giriniz");
            string hafta2CalismaSaati = Console.ReadLine();
            Console.WriteLine("ürün süresini  giriniz");
            string hafta3CalismaSaati = Console.ReadLine();
            Console.WriteLine("ürün süresini  giriniz");
            string hafta4CalismaSaati = Console.ReadLine();


            int evre1 = Convert.ToInt32(evre1UretimSaati);
            int hafta2 = Convert.ToInt32(hafta2CalismaSaati);
            int hafta3 = Convert.ToInt32(hafta3CalismaSaati);
            int hafta4 = Convert.ToInt32(hafta4CalismaSaati);

            int aylikCalismaSaati = evre1 + hafta2 + hafta3 + hafta4;

            Console.WriteLine("Bu ayda toplam çalıştığı saat : " + aylikCalismaSaati);

            Console.ReadLine();*/
        }
    }
}

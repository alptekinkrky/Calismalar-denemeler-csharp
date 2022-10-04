using System;

class Program
{
    public static void Main(string[] args)
    {
        Product urun1 = new Product();
        urun1.UrunAdi = "Redmi Note 11";
        urun1.UrunFiyati = 5.599;
        urun1.SaticiFirma = "Xiaomi";


        Product urun2 = new Product();
        urun2.UrunAdi = "Acer Nitro 5";
        urun2.UrunFiyati = 22.999;
        urun2.SaticiFirma = "Acer";

        Product urun3 = new Product();
        urun3.UrunAdi = "Samsung 43AU8000";
        urun3.UrunFiyati = 8.329;
        urun3.SaticiFirma = "Samsung";



        Product[] urunler = new Product[] { urun1, urun2, urun3 };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunFiyati);
        }

        int t = 0;
        while (t < 3)
        {
            Console.WriteLine(urunler[t].UrunAdi + " : " + urunler[t].UrunFiyati);
            t++;
        }
        foreach (var urun in urunler)
        {
            Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati);
        }
    }
    class Product
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public string SaticiFirma { get; set; }
    }
}
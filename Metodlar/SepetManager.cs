using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string UrunAdi, string aciklama, double fiyat, int stokAdedi)  
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + UrunAdi);
        }
    }
}

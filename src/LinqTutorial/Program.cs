using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var dukkan = new Dukkan();

            Console.WriteLine("Eleman sayısı : {0}", dukkan.Say());

            Console.WriteLine("***********************************************");

            Console.WriteLine("Fiyatı 100 liradan az olan ürün sayısı: {0}", dukkan.Say(u => u.Fiyat < 100));

            Console.WriteLine("Kaynaktaki ürünlerin toplam fiyatı : {0}", dukkan.Topla(u => u.Fiyat));

            double sonuc3 = dukkan.Ortalama(u => u.Fiyat);
            Console.WriteLine("Kaynaktaki ürünlerin ortalam fiyatları : {0}", sonuc3);
            bool sonuc = new int[] { 1, 2, 3, 4, 5, 6, 7 }.BizimAny(s => s % 2 == 1);
            Console.WriteLine(sonuc);

            Console.WriteLine("***********************************************");

            bool sonuc2 = new int[] { 1, 2, 3, 4, 5, 6 }.BizimAll(s => s < 10);
            Console.WriteLine(sonuc2);
            Console.WriteLine("***********************************************");
            Urun[] urunler = dukkan.DiziyeDoldur();
            Console.WriteLine(urunler[0].Ad);

            Console.WriteLine("***********************************************");

            Urun u1 = dukkan.Filtrele(u => u.Ad.StartsWith("M")).IlkiniGetir();
            Console.WriteLine(u1.Ad);

            Urun u2 = dukkan.IlkiniGetir(u => u.Fiyat == 1000);
            Console.WriteLine(u2.Ad);

            Urun u3 = dukkan.Filtrele(u => u.Fiyat < 100).IlkiniYadaVarsayilaniGetir();
            Console.WriteLine(u3.Ad);

            Urun u4 = dukkan.IlkiniYadaVarsayilaniGetir(u => u.Fiyat > 1000);
            if (u4.Ad == null)
                Console.WriteLine("Nesne elde edilemedi.");

            Console.ReadKey(true);
        }

    }
}

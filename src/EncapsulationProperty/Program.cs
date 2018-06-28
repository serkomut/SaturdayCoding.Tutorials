using System;

namespace EncapsulationProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun u = new Urun();
            u.Fiyat = -100;
            Console.WriteLine(u.Fiyat);
            Console.ReadKey(true);
        }
    }
}

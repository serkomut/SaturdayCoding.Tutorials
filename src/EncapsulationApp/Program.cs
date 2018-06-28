using System;

namespace EncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun u = new Urun();
            u.SetFiyat(-100);
            Console.WriteLine(u.GetFiyat());
            Console.ReadKey(true);
        }
    }
}

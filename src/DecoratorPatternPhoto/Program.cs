using System;

namespace DecoratorPatternPhoto
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoList mp = new PhotoList();
            var data = mp.GetHotelPhotos();
            foreach (var m in data)
            {
                Console.WriteLine(m.FileName);
                var p = new PhotoBuilder(m.FromUrl, m.HotelName);

                Console.WriteLine(p.FileName);
            }
            Console.ReadKey();
        }
    }
}

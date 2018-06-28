using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel per = new Personel(1233485858, "Serol", 3000);
            Mudur mdr = new Mudur(9748484848, "Ulaş", 8000, "ARGE");

            Personel per2 = new Mudur(194394994, "Falan", 4000, "ARGE");
            ((Mudur) per2).SorumluOlduguDepertman = "Sorumlu";

            Console.WriteLine(per2.Ad);
            Console.ReadKey(true);
        }
    }
}

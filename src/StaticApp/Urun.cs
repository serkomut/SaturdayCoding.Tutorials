using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApp
{
    public class Urun
    {
        public int Id;
        public string Ad;
        public double Fiyat;
        public static double KdvOran;

        public void ZamYap(double zamOran)
        {
            Fiyat += Fiyat*zamOran;
        }

        public static void KdvOranDegisti(double yeniKdvOran)
        {
            KdvOran = yeniKdvOran;
        }
    }
}

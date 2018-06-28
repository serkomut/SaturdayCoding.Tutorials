using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    class Urun
    {
        public int Id;
        public string Ad;
        private double Fiyat;

        public void SetFiyat(double value)
        {
            if (value > 0)
                Fiyat = value;
            else
                Console.WriteLine("Fiyat negatif olamaz...!");
        }

        public double GetFiyat()
        {
            return Fiyat;
        }
    }
}

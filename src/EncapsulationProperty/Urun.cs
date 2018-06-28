using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProperty
{
    class Urun
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        double _fiyat;

        public double Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value > 0)
                    _fiyat = value;
                else
                    Console.WriteLine("Fiyat negatif olamaz!");
            }
        }
    }
}

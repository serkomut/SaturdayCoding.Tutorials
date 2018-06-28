using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class Urun: IComparable<Urun>
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }

        public Urun(int id, string ad, double fiyat)
        {
            Id = id;
            Ad = ad;
            Fiyat = fiyat;
        }

        public static bool operator >(Urun u1, Urun u2)
        {
            return u1.Fiyat > u2.Fiyat;
        }
        public static bool operator <(Urun u1, Urun u2)
        {
            return u1.Fiyat < u2.Fiyat;
        }

        public int CompareTo(Urun other)
        {
            if (this.Fiyat > other.Fiyat)
                return 1;
            if (this.Fiyat < other.Fiyat)
                return -1;
            else return 0;
        }

        public Urun()
        {
            
        }
    }
}

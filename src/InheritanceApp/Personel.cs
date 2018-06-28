using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    public class Personel
    {
        public long SicilNo { get; set; }
        public string Ad { get; set; }
        public double Maas { get; set; }

        public Personel(long sicilno, string ad, double maas)
        {
            SicilNo = sicilno;
            Ad = ad;
            Maas = maas;
        }
    }
}

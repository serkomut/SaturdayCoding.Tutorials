using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Mudur: Personel
    {
        public string SorumluOlduguDepertman { get; set; }

        public Mudur(long sicilno, string ad, double maas, string sorumluoldugudepartman): base(sicilno, ad, maas)
        {
            SorumluOlduguDepertman = sorumluoldugudepartman;
        }
    }
}

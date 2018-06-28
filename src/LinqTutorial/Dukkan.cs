using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class Dukkan : IEnumerable<Urun>
    {
        Urun[] _urunSepeti;

        public Urun[] UrunSepeti
        {
            get { return _urunSepeti; }
            set { _urunSepeti = value; }
        }

        Urun[] UrunleriGetir()
        {
            return new Urun[]
            {
                new Urun(1,"Monitör",200),
                new Urun(2,"Klavye",80),
                new Urun(3,"Mouse",40),
                new Urun(4,"Laptop",1000),
                new Urun(5,"TV",650)
            };
        }

        public Dukkan()
        {
            UrunSepeti = UrunleriGetir();
        }

        public IEnumerator<Urun> GetEnumerator()
        {
            for (int i = 0; i < UrunSepeti.Length; i++)
                yield return UrunSepeti[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

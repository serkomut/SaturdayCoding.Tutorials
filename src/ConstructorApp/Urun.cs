using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    public class Urun
    {
        public int SId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime SaveDate { get; set; }

        public Urun(int id, string name)
        {
            SId = id;
            Name = name;
            Price = 2.00;
            SaveDate = DateTime.Now;
        }
    }
}

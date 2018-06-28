using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarInterfaceTutorial.Interfaces;
using NUnit.Framework;

namespace CarInterfaceTutorial.Classes
{
    [TestFixture]
    public class Mercedes: ICarProperties
    {
        private const string marka = "Mercedes";
        private const string model = "A Serisi";

        public string Marka
        {
            get { return marka; }
        }

        public string Model
        {
            get
            {
                return model;
            }
        }

        public int Hiz { get; set; }

        public double Fiyat { get; set; }


        public int Gosterge(int deger)
        {
            return (deger);
        }

        [Test]
        public void Bilgiler()
        {
            Console.WriteLine("Marka : "+ Marka);
            Console.WriteLine("Model :" + Model);
            Console.WriteLine("Fiyat :"+Fiyat);
            Console.WriteLine("Hız : "+ Hiz);
            Console.WriteLine("Gösterge : "+ Gosterge(340));
        }
    }
}

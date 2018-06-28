using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInterfaceTutorial.Interfaces
{
 public interface ICarProperties
    {
     string Marka { get; }
     string Model { get; }
     int Hiz { get; set; }
     double Fiyat { get; set; }
     int Gosterge(int deger);
     void Bilgiler();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Samsung: IBasliklar, IUzunluk
    {
        #region IBaslik Members
        string IBasliklar.Isim()
        {
            return "Samsung S3";
        }

        string IBasliklar.AnaBaslik()
        {
            return "Başlık Yazılıyor.";
        }

        string IBasliklar.AltBaslik()
        {
            return "Altbaşlık Yazılıyor.";
        }

        string IBasliklar.Yazdir()
        {
            return "IBaşlık Yazdır.";
        }
        #endregion

        #region IUzunluk Members
        string IUzunluk.En()
        {
            return "70,6 mm";
        }

        string IUzunluk.Boy()
        {
            return "136,6 mm";
        }

        string IUzunluk.Kalinlik()
        {
            return "7,4 mm";
        }

        string IUzunluk.Yazdir()
        {
            return "IUzunluk Yazdır Metodu";
        }
        #endregion
    }
}

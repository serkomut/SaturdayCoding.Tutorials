using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NHibernate.Api.Driver.Test
{
    [TestFixture]
    public class ApiFixture
    {
        [Test]
        public void DataTest()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var kasa = new MyKasa()
                    {
                        KasaNo = 11,
                        Icerik = "İçerik",
                        Grup = "B",
                        RecId = 2,
                        Tarih = DateTime.Now
                    };
                    session.Save(kasa);
                    var result = session.Get<MyKasa>(1);
                    Console.WriteLine(result);
                    transaction.Commit();
                }
            }
        }

        //private MyKasa[] _kasa =
        //{
        //    new MyKasa {RecId = 1, Grup = "BTM", Icerik = "İçerik 1", KasaNo = 15, Tarih = DateTime.Now},
        //    new MyKasa {RecId = 2, Grup = "BTM", Icerik = "İçerik 2", KasaNo = 16, Tarih = DateTime.Now},
        //    new MyKasa {RecId = 3, Grup = "BTM", Icerik = "İçerik 1", KasaNo = 15, Tarih = DateTime.Now},
        //    new MyKasa {RecId = 4, Grup = "BTM", Icerik = "İçerik 2", KasaNo = 16, Tarih = DateTime.Now}
        //};

        

    }
}

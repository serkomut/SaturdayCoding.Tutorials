using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace NHibernate.Api.Driver
{
    public class MyKasa
    {
        public virtual int RecId { get; set; }
        public virtual int KasaNo { get; set; }
        public virtual string Icerik { get; set; }
        public virtual string Grup { get; set; }
        public virtual DateTime Tarih { get; set; }
    }

    public class MyKasaMap : ClassMap<MyKasa>
    {
        public MyKasaMap()
        {
            Table("MyKasa");
            Id(x => x.RecId);
            Map(x => x.KasaNo).Not.Nullable();
            Map(x => x.Icerik);
            Map(x => x.Grup);
            Map(x => x.Tarih);
        }
    }
}

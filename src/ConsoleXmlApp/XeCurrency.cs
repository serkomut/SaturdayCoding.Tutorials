using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleXmlApp
{
    public class XeCurrency
    {
        [XmlElement(ElementName = "csymbol")]
        public string Csymbol { get; set; }

        [XmlElement(ElementName = "cname")]
        public string Cname { get; set; }

        [XmlElement(ElementName = "crate")]
        public double Crate { get; set; }

        [XmlElement(ElementName = "cinverse")]
        public double Cinverse { get; set; }

        readonly XDocument _xedoc = XDocument.Load("D:\\tcur.xml");
        List<XeCurrency> _xe = new List<XeCurrency>();
        public void GetFromRate(string fromrate)
        {
            
            _xe = (from z in _xedoc.Descendants("currency")
                   select new XeCurrency
                   {
                       Csymbol = z.Element("csymbol").Value,
                       Cname = z.Element("cname").Value,
                       Crate = Convert.ToDouble(z.Element("crate").Value),
                       Cinverse = Convert.ToDouble(z.Element("cinverse").Value)
                       
                   }).Where(x => x.Csymbol == fromrate).ToList();
            foreach (var z in _xe)
            {
                Console.WriteLine(z.Cname);
            }
        }

        public void Gett(string v)
        {
            _xe = (from z in _xedoc.Descendants("currency") select new XeCurrency(){Cinverse = Convert.ToDouble(z.Element("cinverse").Value)}).Where(x => x.Csymbol == v).ToList();
            foreach (var x in _xe)
            {
                Console.WriteLine(x.Cinverse);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleXmlApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //XDocument cur = XDocument.Load("D:\\tcur.xml");
            //List<XeCurrency> xe = new List<XeCurrency>();
            //xe = (from z in cur.Descendants("currency")
            //      select new XeCurrency()
            //{
            //    Crate = Convert.ToDouble(z.Element("crate").Value),
            //    Cname = z.Element("cname").Value,
            //    Csymbol = z.Element("csymbol").Value
            //}).Where(w=>w.Csymbol=="TRY").ToList();

            //foreach (var x in xe)
            //{
            //    Console.WriteLine("CRate : " + x.Crate + " Cname : " + x.Cname);
            //}
            //Console.ReadKey(true);

            //double amount = 0;
            //string fromCurrency;
            //string toCurrency;

            //amount = double.Parse("20", NumberStyles.Any, CultureInfo.InvariantCulture);
            //fromCurrency = "TRY";
            //toCurrency = "USD";
            //if (amount != 0)
            //{
            //    var web = new WebClient();
            //    string url = string.Format("http://www.google.co.in/ig/calculator?hl=en&q={2}{0}%3D%3F{1}", fromCurrency.ToUpper(), toCurrency.ToUpper(), amount);
            //    string response = web.DownloadString(url);
            //    var regex = new Regex("rhs: \\\"(\\d*.\\d*)");
            //    decimal rate = Convert.(regex.Match(response).Groups[1].Value);
            //    Console.WriteLine("Real-Time Rate: 1 TRY = " + rate + " USD");
            //    Console.ReadKey(true);
            //}

            //ma.GetFromRate("TRY");
            //ma.Gett("TRY");

            //XmlDocument xedoc = new XmlDocument();
            //xedoc.Load("http://www.xe.com/datafeed/samples/sample-xml-usd.xml");
            //foreach (XmlNode x in xedoc.GetElementsByTagName("currency"))
            //{
            //    Console.WriteLine(x.Name);
            //    Console.WriteLine("\t{0}", x["cname"].InnerText);
            //}
            
            var con = new XeCurrencyConverter();
            Console.WriteLine(con.GetReslutRate("TRY", 30, "USD"));
            Console.ReadKey(true);
        }

    
        
        public static Double ConvertCurrency(string fromrate, string value, string torate)
        {
            const string url = "http://www.xe.com/datafeed/samples/sample-xml-usd.xml";
            double incurcode = 0;
            double outcurcode = 0;

            try
            {
                double result = 0;
                if (value.Equals("0"))
                {
                    result = 0;
                }
                else
                {
                    if (fromrate.Equals(torate))
                    {
                        result = Convert.ToDouble(value);
                    }
                    else
                    {
                        var xmlDoc = XDocument.Load(url);

                        foreach (var z in xmlDoc.Descendants("currency"))
                        {
                            if (z.Element("csymbol").Value.Equals(fromrate))
                            {
                                incurcode = Convert.ToDouble(z.Element("crate").Value);
                            }
                            else if (z.Element("csymbol").Value.Equals(torate))
                            {
                                outcurcode = Convert.ToDouble(z.Element("crate").Value);
                            }
                        }

                        var fromVal = Convert.ToDouble(incurcode);
                        var toVal = Convert.ToDouble(outcurcode);
                        var baseResult = (1 / fromVal);
                        var currVal = baseResult * toVal * Convert.ToDouble(value);
                        result = currVal;
                    }
                }
                return Math.Round(result, 4);
            }
            catch (FormatException fex)
            {
                return 0;
            }
        }

        public static Double ConvertCurrencyOld(string incurrcode, string incurrvalue, string outcurrcode)
        {
            string currencyUrl = "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml";
            string rate = "";
            string incurrcodetoeuro = "";
            string outcurrcodetoeuro = "";

            Double outcurrencyvalue = 0;
            try
            {
                if (incurrvalue.Equals("0"))
                {
                    outcurrencyvalue = 0;
                }
                else
                {
                    if (incurrcode.Equals(outcurrcode))
                    {
                        outcurrencyvalue = Convert.ToDouble(incurrvalue);
                    }
                    else
                    {
                        XDocument xmlDoc = XDocument.Load(currencyUrl);
                        foreach (XElement element in xmlDoc.Root.Descendants())
                        {
                            XName name = element.Name;
                            if (name.LocalName == "Cube")
                            {
                                foreach (XElement elem in element.DescendantNodes())
                                {
                                    foreach (XElement element1 in elem.DescendantNodes())
                                    {
                                        if (element1.Attribute("currency").Value.Equals(incurrcode))
                                        {
                                            incurrcodetoeuro = element1.LastAttribute.Value.ToString();
                                        }
                                        else if (element1.Attribute("currency").Value.Equals(outcurrcode))
                                        {
                                            outcurrcodetoeuro = element1.LastAttribute.Value.ToString();
                                        }

                                    }

                                }
                            }

                        }

                        if (incurrcode.Equals("EUR"))
                        {
                            rate = outcurrcodetoeuro;
                            Double currVal = Convert.ToDouble(rate) * Convert.ToDouble(incurrvalue);
                            outcurrencyvalue = currVal;
                        }
                        else if (outcurrcode.Equals("EUR"))
                        {
                            rate = incurrcodetoeuro;
                            Double currVal = (1 / Convert.ToDouble(rate)) * Convert.ToDouble(incurrvalue);
                            outcurrencyvalue = currVal;

                        }
                        else
                        {
                            Double fromVal = Convert.ToDouble(incurrcodetoeuro);
                            Double toVal = Convert.ToDouble(outcurrcodetoeuro);
                            Double baseResult = (1 / fromVal);
                            Double currVal = baseResult * toVal * Convert.ToDouble(incurrvalue);
                            outcurrencyvalue = currVal;
                        }
                    }
                }
                return Math.Round(outcurrencyvalue, 4);
            }
            catch (FormatException fex)
            {
                return 0;
            }
        }
    }
}

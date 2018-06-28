using System;
using System.Xml.Linq;

namespace ConsoleXmlApp
{
    public class XeCurrencyConverter
    {
        public double Incurcode { get; set; }
        public double Outcurcode { get; set; }
        public double ResultRate { get; set; }

        public double GetReslutRate(string fromrate, double value, string torate)
        {
            const string url = "http://www.xe.com/datafeed/samples/sample-xml-usd.xml";

            try
            {
                if (value.Equals(0))
                {
                    ResultRate = 0;
                }
                else
                {
                    if (fromrate.Equals(torate))
                    {
                        ResultRate = Convert.ToDouble(value);
                    }
                    else
                    {
                        var xmlDoc = XDocument.Load(url);

                        foreach (var z in xmlDoc.Descendants("currency"))
                        {
                            var xElement = z.Element("csymbol");
                            var xElement2 = z.Element("csymbol");
                            var xCrate = z.Element("crate").Value;

                            if (xElement != null && xElement.Value.Equals(fromrate))
                            {
                                Incurcode = Convert.ToDouble(xCrate);
                            }
                            else if (xElement2 != null && xElement2.Value.Equals(torate))
                            {
                                Outcurcode = Convert.ToDouble(xCrate);
                            }
                        }
                        var baseResult = (1 / Incurcode);
                        var currVal = baseResult * Outcurcode * value;
                        ResultRate = currVal;
                    }
                }
                return Math.Round(ResultRate, 3);
            }
            catch (FormatException fex)
            {
                return 0;
            }
        }
    }
}

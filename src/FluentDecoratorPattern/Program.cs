using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FluentDecoratorPattern
{
    class Program
    {
        //http://polymorphicview.blogspot.com.tr/2008/08/extension-methods-as-new-fluent.html
        static void Main(string[] args)
        {
            IList<string> outputString = new List<string>()
            {
                "Hello World",
                "This isa fluent Decorator Pattern test!",
                "dit I work?"
            };
            var myDecoratedString = new SimpleString().WithNumbering().WithTimestaped();
            myDecoratedString.Write(outputString);

            const string imageUrl = @"";
            string saveLocation = @"D:\someImage.jpg";

            //****
            WebClient webClient = new WebClient();
            webClient.DownloadFile(imageUrl, @"D:\Deniyorum.jpg");
            Console.ReadKey(true);
        }

        public static XmlDocument MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());
                return (xmlDoc);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                Console.Read();
                return null;
            }
        }
    }
}

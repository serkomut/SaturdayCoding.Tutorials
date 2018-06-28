using System;
using NUnit.Framework;

namespace MyPatern.Driver.Test
{
    [TestFixture]
    public class MyPatternFixture
    {
       
        [Test]
        public void GetUser()
        {
          var yeni =  new MyBuilder("Serol", "Güzel")
                .Age(110)
                .Mail("serkomut@gmail.com")
                .Phone("5416510875")
                .Address("Bu bir adres")
                .SendMail().Build();
            Console.WriteLine(yeni.Address);

        }
    }
}

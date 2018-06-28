using System;
using NUnit.Framework;

namespace Tutorial.GetPropertyNames
{
    [TestFixture]
    public class PropertyTestFixture
    {
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        [Test]
        public void NameSet()
        {
            Name = "Deneme";
            var testName = Name;
            Console.WriteLine(testName);
        }
    }
}

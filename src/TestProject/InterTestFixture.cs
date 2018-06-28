using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class InterTestFixture
    {
        [Test]
        public void MyIterface()
        {
            var sm = new Samsung();
            var baslik = (IBasliklar) sm;
        }
    }
}

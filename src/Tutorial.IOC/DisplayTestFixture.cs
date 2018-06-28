using NUnit.Framework;

namespace Tutorial.IOC
{
    [TestFixture]
    public class DisplayTestFixture
    {
        [Test]
        public void Displayer_Msg()
        {
            var sample = new Sample(new Screen())
            {
                Msg = "Merhaba dunya!"
            };
            sample.Test();
        }

        [Test]
        public void Context_Msg()
        {
            Context.DependencyRegister("page", new Page());
            Context.DependencyRegister("screen", new Screen());
            var sample = Context.CreateSample();
            sample.Test();
        }
    }
}
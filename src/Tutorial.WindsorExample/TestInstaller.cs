using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    public class TestInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IMessageSender>().ImplementedBy<SmsSender>().LifestyleSingleton(),
                Component.For<IMessageSender>().ImplementedBy<MailSender>().LifestyleSingleton(),
                Component.For<ILoger>().ImplementedBy<DbLogger>().LifestyleSingleton());
        }
    }
}

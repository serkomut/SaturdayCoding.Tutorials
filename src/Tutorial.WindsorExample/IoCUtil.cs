using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    public static class IoCUtil
    {
        private static IWindsorContainer container = null;

        private static IWindsorContainer BootstrapContainer()
        {
            return new WindsorContainer().Register(Component.For<IMessageSender>().ImplementedBy<SmsSender>(),
                Component.For<IMessageSender>().ImplementedBy<MailSender>(),
                Component.For<ILoger>().ImplementedBy<DbLogger>());
        }

        private static IWindsorContainer Container
        {
            get { return container ?? (container = BootstrapContainer()); }
            set { container = value; }
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

    }
}

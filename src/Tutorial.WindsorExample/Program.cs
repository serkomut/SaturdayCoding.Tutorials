using System;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    class Program
    {
        private static IWindsorContainer container;
        private static DefaultConfigurationStore config;
        static void Main(string[] args)
        {
            //var logger = IoCUtil.Resolve<ILoger>();
            //var messageSender = IoCUtil.Resolve<IMessageSender>();

            //logger.WriteLog("Log Text");
            //messageSender.SendMessage("Message Text");

            config = new DefaultConfigurationStore();
            container = new WindsorContainer();


            var installer = new TestInstaller();
            installer.Install(container, config);
            var resolver = new WindsorDependencyResolver(container.Kernel);
            var logs = resolver.GetServices(typeof (ILoger));
            foreach (var log in logs)
            {
                var kk = log;
                Console.WriteLine(log);
            }
            resolver.BeginScope();

            Console.ReadLine();
        }

    }
}

using System.IO;
using System.Linq;
using System.Reflection;
using Castle.Core.Internal;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    public class TutorialInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var installers = Assembly
                    .GetExecutingAssembly()
                    .GetBaseDirectory()
                    .AllUniqueAssemblies()
                    .Where(x => x.Name.ToLowerInvariant().StartsWith("Tutorial."))
                    .Select(x => FromAssembly.Named(Path.GetFileNameWithoutExtension(x.Name)))
                    .ToArray();

           Assembly
                .GetExecutingAssembly()
                .GetBaseDirectory()
                .AllUniqueAssemblies()
                .ForEach(x =>
                             container.Register(
                                                Classes
                                                    .FromAssemblyNamed(Path.GetFileNameWithoutExtension(x.Name))
                                                    .BasedOn<IGet>()
                                                    .LifestyleScoped()));
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Tutorial.WindsorExample
{
    public static class AssemblyExtensions
    {
        public static DirectoryInfo GetBaseDirectory(this Assembly assembly)
        {
            var baseDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            if (baseDirectory.GetDirectories().Any(x => x.Name.ToLowerInvariant() == "bin"))
                baseDirectory = new DirectoryInfo(Path.Combine(baseDirectory.FullName, "bin"));
            return baseDirectory;
        }

        public static IEnumerable<FileInfo> AllUniqueAssemblies(this DirectoryInfo parent)
        {
            var assemblies = parent.GetFiles("*.dll", SearchOption.AllDirectories);
            return assemblies.ToLookup(x => x.Name, x => x).Select(x => x.First());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;

namespace Tutorial.IOC
{
    public class Context
    {
        public static Sample CreateSample()
        {
            var ds = new DataSet();
            ds.ReadXml("../../Dependency.xml");

            var displayer = ResolveDependency(ds.Tables["sample"].Rows[0]["displayer"].ToString());
            
            return new Sample(displayer)
            {
                Msg = ds.Tables["sample"].Rows[0]["msg"].ToString()
            };
        }

        static readonly Dictionary<string, IDisplayer> dependencies; 
        static Context()
        {
            dependencies = new Dictionary<string, IDisplayer>();
        }

        public static void DependencyRegister(string name, IDisplayer dependency)
        {
            dependencies.Add(name, dependency);
        }

        public static IDisplayer ResolveDependency(string name)
        {
            if (dependencies.ContainsKey(name))
            {
                return dependencies[name];
            }
            throw new Exception("Dependency object not found!");
        }
    }
}
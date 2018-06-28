using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDecoratorPattern
{
    public static class SimpleStringDecorators
    {
        public static ISimpleString WithNumbering(this ISimpleString componet)
        {
            return new SimpleClassDecorator(output =>
            {
                IList<string> t = new List<string>();
                var i = 1;
                foreach (var s in output)
                {
                    t.Add(string.Format("{0}:{1}", i, s));
                    ++i;
                }
                componet.Write(t);
            });
        }

        public static ISimpleString WithTimestaped(this ISimpleString component)
        {
            return new SimpleClassDecorator(output =>
            {
                IList<string> t = new List<string>();
                foreach (var s in output)
                {
                    t.Add(string.Format("{0}:{1}", DateTime.Now, s));
                    component.Write(t);
                }
            });
        }
    }
}

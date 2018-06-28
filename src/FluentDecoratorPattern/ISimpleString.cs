using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentDecoratorPattern
{
    public interface ISimpleString
    {
        void Write(IList<string> output);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FluentDecoratorPattern
{
    public class SimpleClassDecorator:ISimpleString
    {
        Action<IList<string>> action;

        public SimpleClassDecorator(Action<IList<string>> outputString)
        {
            action = outputString;
        }
        public void Write(IList<string> output)
        {
            action.Invoke(output);
        }
    }
}

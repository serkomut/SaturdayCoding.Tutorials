using System;
using System.Collections.Generic;

namespace FluentDecoratorPattern
{
    public class SimpleString: ISimpleString
    {
        public void Write(IList<string> output)
        {
            foreach (var s in output)
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    public class DbLogger: ILoger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("Logger : {0}", message);
        }
    }
}
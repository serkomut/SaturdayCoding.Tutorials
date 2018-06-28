using System;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    public class FileLogger : ILoger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("FileLogger : {0}", message);
        }
    }
}
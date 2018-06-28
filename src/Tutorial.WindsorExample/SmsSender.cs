using System;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMSSender : {0}", message);
        }
    }
}
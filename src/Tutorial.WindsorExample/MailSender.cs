using System;
using Tutorial.WindsorExample.Infrastructure;

namespace Tutorial.WindsorExample
{
    public class MailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("MailSender : {0}", message);
        }
    }
}
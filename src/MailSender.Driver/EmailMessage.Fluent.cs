using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Driver.Fluent;

namespace MailSender.Driver
{
    public partial class EmailMessage : IFluentEmailMessage
    {
        private IFluentEmailSender _sender;

        public EmailMessage(IFluentEmailSender sender)
        {
            _sender = sender;
        }

        public IFluentEmailMessage From(string fromAddress)
        {
            FromAddress = fromAddress;
            return this;
        }

        public IFluentEmailMessage To(string toAddress)
        {
            ToAddress = toAddress;
            return this;
        }

        public IFluentEmailMessage YourMessage(string message)
        {
            Message = message;
            return this;
        }

        public IFluentEmailMessage YourSubject(string subject)
        {
            Subject = subject;
            return this;
        }

        public IFluentEmailSender Done()
        {
            return _sender;
        }
    }
}

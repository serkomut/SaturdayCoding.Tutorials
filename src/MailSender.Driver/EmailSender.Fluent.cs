using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Driver.Fluent;

namespace MailSender.Driver
{
    public partial class EmailSender : IFluentEmailSender
    {
        EmailMessage _message;

        public IFluentEmailSender FromServer(string host)
        {
            EmailServer = host;
            return this;
        }

        public IFluentEmailSender FluentCredentials(string username, string password)
        {
            SetCredentials(username, password);
            return this;
        }

        public IFluentEmailMessage CreateEmail()
        {
            _message = new EmailMessage(this);
            return _message;
        }

        public void Send()
        {
            Send(_message);
        }
    }
}

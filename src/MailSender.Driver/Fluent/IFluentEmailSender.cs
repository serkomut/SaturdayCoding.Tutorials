using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Driver.Fluent
{
    public interface IFluentEmailSender
    {
        IFluentEmailSender FromServer(string host);
        IFluentEmailSender FluentCredentials(string username, string password);
        IFluentEmailMessage CreateEmail();
        void Send();
    }
}

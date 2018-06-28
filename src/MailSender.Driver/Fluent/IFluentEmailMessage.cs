using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Driver.Fluent
{
    public interface IFluentEmailMessage
    {
        IFluentEmailMessage From(string fromAddress);
        IFluentEmailMessage To(string toAddress);
        IFluentEmailMessage YourMessage(string message);
        IFluentEmailMessage YourSubject(string subject);
        IFluentEmailSender Done();
    }
}

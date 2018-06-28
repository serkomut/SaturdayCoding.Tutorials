using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Driver
{
    public partial class EmailMessage
    {
        public String FromAddress { get; set; }
        public String ToAddress { get; set; }
        public String Subject { get; set; }
        public String Message { get; set; }

        public EmailMessage() { }
    }
}

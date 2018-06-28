using NUnit.Framework;

namespace MailSender.Driver.Test
{
     [TestFixture]
    public class EmailSenderFixture
    {
         [Test]
         public void EmilSender_Build()
         {
             new EmailSender().FromServer("smtp.gmail.com")
                 .FluentCredentials("serkomut@gmail.com", "buson@*2536")
                 .CreateEmail().From("from@domain.com")
                 .To("serolguzel@gmail.com")
                 .YourMessage("Your message!")
                 .YourSubject("Subject").Done().Send();
            
         }

         //Old method...
         [Test]
         public void SendMail_Buil()
         {
             EmailSender.SendMail("serkomut@gmail.com", "serolguzel@gmail.com", "Subject", "Your Message", "smtp.gmail.com", "buson@*2536");
         }
    }

}

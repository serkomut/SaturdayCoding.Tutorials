using System.Data.SqlClient;
using System.IO;
using MailSender.Driver;

namespace MyPatern.Driver
{
    public class MyPattern
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public MyPattern(MyBuilder builder)
        {
            FirstName = builder.Name;
            LastName = builder.Surname;
            Mail = builder.BuMail;
            Age = builder.BuAge;
            Phone = builder.BuPhone;
            Address = builder.BuAddress;
        }

        public MyPattern(string firstName, string lastName, string mail, int age, string phone, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Mail = mail;
            Age = age;
            Phone = phone;
            Address = address;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string lastName)
        {
            LastName = lastName;
        }

        public string GetMail()
        {
            return Mail;
        }
        public void SetMail(string mail)
        {
            Mail = mail;
        }
        
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            Age = age;
        }
        public string GetPhone()
        {
            return Phone;
        }
        public void SetPhone(string phone)
        {
            Phone = phone;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string address)
        {
            Address = address;
        }

        public void SendMail()
        {
            new EmailSender().FromServer("smtp.gmail.com")
                .FluentCredentials("serol.guzel@paximum.com", "komut2018")
                .CreateEmail().From("serol.guzel@paximum.com")
                .To(Mail)
                .YourMessage(FirstName + " " + LastName + " " + Age + " " + Address)
                .YourSubject("Subject").Done().Send();
        }
    }
}

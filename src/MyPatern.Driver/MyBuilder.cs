using System;

namespace MyPatern.Driver
{
    public class MyBuilder {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string BuMail { get; set; }
        public int BuAge { get; set; }
        public string BuPhone { get; set; }
        public string BuAddress { get; set; }

        public MyBuilder(string firstName, string lastName)
        {
            Name = firstName;
            Surname = lastName;
        }

        public MyBuilder Mail(string mail)
        {
            BuMail = mail;
            return this;
        }

        public MyBuilder Age(int age)
        {
            BuAge = age;
            return this;
        }

        public MyBuilder Phone(string phone)
        {
            BuPhone = phone;
            return this;
        }

        public MyBuilder Address(string address)
        {
            BuAddress = address;
            return this;
        }

        public MyBuilder SendMail()
        {
            var pattern = new MyPattern(this);
            if (pattern.GetMail() == null)
            {
                throw new Exception("Mail adresi olmadığı için mail gönderme başarısız :(");
            }
            return this;
        }

        public MyPattern Build()
        {
            var pattern = new MyPattern(this);
            if (pattern.GetAge() > 120)
            {
                throw new Exception("Çok büyük bir yaş bu! :(");
            }
            return pattern;
        }
    }
}
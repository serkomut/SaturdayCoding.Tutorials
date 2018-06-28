using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using NUnit.Framework;

namespace Tutorial.GetPropertyNames
{
    [TestFixture]
    public class GetPropertNameTestFixture
    {
        [Test]
        public void GetPropertyNames()
        {
            var properties = new Person(new Dictionary<string, object>()).GetType().GetProperties();
            foreach (var pro in properties)
            {
                Console.WriteLine("{0} : {1}", pro.Name, pro.PropertyType);
                if (pro.PropertyType.ToString() == "Tutorial.GetPropertyNames.Email")
                {
                    var address = new Address();
                    var email = pro.PropertyType.GetProperties();
                    foreach (var e in email)
                    {
                        Console.WriteLine("{0} : {1}", e.Name, e.PropertyType);
                    }
                }
            }

            var dyn = GetDynamicObject(new Dictionary<string, object>()
            {
                {"Age", 12},
                {"Zaman", "zaman"}
            });

            Console.WriteLine(dyn.Zaman);
            dyn.Age = 150;
        }

        [Test]
        public void AddNewProperty_ToClass()
        {
            dynamic list = new List<MyClass>();
            for (var i = 0; i < 10; i++)
            {
                dynamic obje = new MyDynObject(new Dictionary<string, object>()
                {
                    {"Name", string.Empty},
                    {"LastName", string.Empty},
                    {"Age", 10}
                });
                list.Add(obje);
                obje.Name = "Serol";
                obje.LastName = "Güzel";
                obje.Age = 10;
            }
            foreach (var li in list)
            {
                Console.WriteLine(li.Name + " " + li.LastName);
            }

        }

        public static dynamic GetDynamicObject(Dictionary<string, object> properties)
        {
            var dynamicObject = new ExpandoObject() as IDictionary<string, Object>;
            foreach (var property in properties)
            {
                dynamicObject.Add(property.Key, property.Value);
            }
            return dynamicObject;
        }

        public string GetPropertyName<T, TReturn>(Expression<Func<T, TReturn>> expression)
        {
            var body = (MemberExpression)expression.Body;
            return body.Member.Name;
        }

        public static string GetPropertyName<T>(Expression<Func<T>> expression)
        {
            var body = (MemberExpression)expression.Body;
            return body.Member.Name;
        }
    }
    public sealed class MyDynObject : DynamicObject
    {
        private readonly Dictionary<string, object> _properties;

        public MyDynObject(Dictionary<string, object> properties)
        {
            _properties = properties;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return _properties.Keys;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                result = _properties[binder.Name];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                _properties[binder.Name] = value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class MyClass
    {
       
    }

    public class Person
    {
        private readonly Dictionary<string, object> properties;
        public Person(Dictionary<string, object> properties)
        {
            this.properties = properties;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime BirdDay { get; set; }
        public IEnumerable<Email> Emails { get; set; }
        public Email Email { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string PostCode { get; set; }
    }

    public class Email
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
    }
}

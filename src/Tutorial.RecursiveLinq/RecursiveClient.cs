using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Tutorial.RecursiveLinq
{
    [TestFixture]
    public class RecursiveClient
    {
        [Test]
        public void RecursiveLinq()
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    ParentId = 0,
                    Name = "Serol Güzel"
                },
                new Person
                {
                    Id = 2,
                    ParentId = 0,
                    Name = "Şengul Güzel"
                },
                new Person
                {
                    Id = 3,
                    ParentId = 1,
                    Name = "Tarık Sancar"
                },
                new Person
                {
                    Id = 4,
                    ParentId = 3,
                    Name = "Batuhan Kalkan"
                },
                new Person
                {
                    Id = 5,
                    ParentId = 4,
                    Name = "Tülay Çoban"
                },
                new Person
                {
                    Id = 6,
                    ParentId = 4,
                    Name = "Aykut Aras"
                },
                new Person
                {
                    Id = 7,
                    ParentId = 2,
                    Name = "Vitaly Tsvayer"
                }
            };


            Func<int, dynamic> query = null;
            query = pid => persons.Where(p => p.ParentId == pid).Select(p => new
            {
                p.Id,
                p.Name,
                Persons = query(p.Id)
            });

            var result = query(0);
            var jsonConvert = JsonConvert.SerializeObject(result);
            var json = JsonConvert.DeserializeObject(jsonConvert);
        }

        [Test]
        public void Ilginc()
        {
            var a = 5;
            var b = "3" + 5;
            var c = a;
            Console.WriteLine(c);
        }

        [Test]
        public void ObservableCollection()
        {
            var people = new PersonObservable();

        }   
    }
}

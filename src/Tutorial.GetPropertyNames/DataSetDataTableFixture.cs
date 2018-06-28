using System.Collections.Generic;
using System.Data;
using System.Reflection;
using NUnit.Framework;

namespace Tutorial.GetPropertyNames
{
    [TestFixture]
    public class DataSetDataTableFixture
    {
        [Test]
        public void DataSetInit()
        {
            var students = new List<Student>()
            {
                new Student() {Name = "Jack", Age = 15, StudentId = 100},
                new Student() {Name = "Smith", Age = 15, StudentId = 101},
                new Student() {Name = "Smit", Age = 15, StudentId = 102}
            };
            var list = new List<User>
            {
                new User
                {
                    Age = 23,
                    Name = "Serol",
                    Surname = "Güzel"
                },
                new User
                {
                    Age = 23,
                    Name = "Sengul",
                    Surname = "Güzel"
                }
            };
            var table = ToDataTable(students);
            table.ToList<User>();
        }

        [Test]
        public void ProductTest()
        {
            var pro1 = new Product();
            var pro2 = new Product();
            var pro3 = new Product();
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);
            var Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}

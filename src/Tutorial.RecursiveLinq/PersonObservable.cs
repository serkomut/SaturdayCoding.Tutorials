using System.Collections.ObjectModel;

namespace Tutorial.RecursiveLinq
{
    public class PersonObservable : ObservableCollection<Person>
    {
        public PersonObservable()
        {
            var p1 = new Person
            {
                Id = 1,
                Name = "Serol",
                ParentId = 0
            };

            var p2 = new Person
            {
                Id = 2,
                Name = "Dilan",
                ParentId = 0
            };

            this.Add(p1);
            this.Add(p2);
        }
    }
}

using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person("Tom"),
                new Person("Bob"),
                new Person("Sam")
            };

        }
        
        class Person
        {
            public string Name { get; }
            public Person(string name) => Name = name;
        }
    }
}

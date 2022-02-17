using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<string> { "Tom", "Sam", "Bob" };
            Queue<string> people = new Queue<string>(employees);

            foreach (var person in people) Console.WriteLine(person);

            Console.WriteLine(people.Count); // 3



        }

    }
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
}


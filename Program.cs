using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<string>() { "Tom", "Bob", "Sam" };

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            // Вывод программы:
            // Tom
            // Bob
            // Sam


        }

        class Person
        {
            public string Name { get; }
            public Person(string name) => Name = name;
        }
    }
}

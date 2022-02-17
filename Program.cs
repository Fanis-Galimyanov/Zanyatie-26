using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<string>() { "Tom", "Bob", "Sam" };

            string firstPerson = people[0]; // получаем первый элемент
            Console.WriteLine(firstPerson); // Tom
            people[0] = "Mike";     // изменяем первый элемент
            Console.WriteLine(people[0]); // Mike



        }

        class Person
        {
            public string Name { get; }
            public Person(string name) => Name = name;
        }
    }
}

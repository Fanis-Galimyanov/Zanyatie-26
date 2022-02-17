using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Queue<string>();

            // добавляем элементы
            people.Enqueue("Tom");  // people = { Tom }
            people.Enqueue("Bob");  // people = { Tom, Bob }
            people.Enqueue("Sam");  // people = { Tom, Bob, Sam }

            // получаем элемент из самого начала очереди 
            var firstPerson = people.Peek();
            Console.WriteLine(firstPerson); // Tom

            // удаляем элементы
            var person1 = people.Dequeue();  // people = { Bob, Sam  }
            Console.WriteLine(person1); // Tom
            var person2 = people.Dequeue();  // people = { Sam  }
            Console.WriteLine(person2); // Bob
            var person3 = people.Dequeue();  // people = {  }
            Console.WriteLine(person3); // Sam




        }

    }
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
}


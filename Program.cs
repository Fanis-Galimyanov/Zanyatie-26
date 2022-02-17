using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Stack<string>();
            people.Push("Tom");
            // people = { Tom }
            people.Push("Sam");
            // people = { Sam, Tom }
            people.Push("Bob");
            // people = { Bob, Sam, Tom }

            // получаем первый элемент стека без его удаления 
            string headPerson = people.Peek();
            Console.WriteLine(headPerson);  // Bob

            string person1 = people.Pop();
            // people = { Sam, Tom }
            Console.WriteLine(person1);  // Bob

            string person2 = people.Pop();
            // people = { Tom }
            Console.WriteLine(person2);  // Sam

            string person3 = people.Pop();
            // people = { }
            Console.WriteLine(person3);  // Tom




        }
    }

}



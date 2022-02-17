using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<string> { "Tom", "Sam", "Bob" };
            Stack<string> people = new Stack<string>(employees);
            foreach (var person in people) Console.WriteLine(person);

            Console.WriteLine(people.Count); // 3



        }
    }

}



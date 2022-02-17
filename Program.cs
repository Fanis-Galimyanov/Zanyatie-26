using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {

            var employees = new List<string> { "Tom", "Sam", "Bob" };

            LinkedList<string> people = new LinkedList<string>(employees);
            Console.WriteLine(people.Count);            // 3
            Console.WriteLine(people.First?.Value);    // Tom
            Console.WriteLine(people.Last?.Value);    // Bob



        }
    }
}

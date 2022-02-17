using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var mike = new KeyValuePair<int, string>(56, "Mike");
            var employees = new List<KeyValuePair<int, string>>() { mike };
            var people = new Dictionary<int, string>(employees)
            {
                [5] = "Tom",
                [6] = "Sam",
                [7] = "Bob",
            };

            foreach (var person in people)
            {
                Console.WriteLine($"key: {person.Key}  value: {person.Value}");
            }





        }
    }

}



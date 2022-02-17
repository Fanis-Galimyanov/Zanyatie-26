﻿using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

            // переворачиваем весь список
            people.Reverse();
            // people = { "Bob","Sam", "Mike", "Tom", "Eugene"};

            var people2 = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };
            // переворачиваем часть только 3 элемента с индекса 1
            people2.Reverse(1, 3);
            // people2 = { "Eugene","Sam", "Mike", "Tom", "Bob" };



            /* foreach (var person in partOfPeople)
             {
                 Console.WriteLine(person);
             }*/

        }
    }
}

﻿using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

            people.RemoveAt(1); //  удаляем второй элемент
                                // people = { "Eugene", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

            people.Remove("Tom"); //  удаляем элемент "Tom"
                                  // people = { "Eugene", "Kate", "Bob", "Sam", "Tom", "Alice" };

            // удаляем из списка все элементы, длина строки которых равна 3
            people.RemoveAll(person => person.Length == 3);
            // people = { "Eugene", "Kate", "Alice" };

            // удаляем из списка 2 элемента начиная с индекса 1
            people.RemoveRange(1, 2);
            // people = { "Eugene"};

            // полностью очищаем список
            people.Clear();
            // people = {  };



            /*foreach (var person in people)
            {
                Console.WriteLine(person);
            }*/

        }
    }
}

using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

            var containsBob = people.Contains("Bob");     //  true
            var containsBill = people.Contains("Bill");    // false

            // проверяем, есть ли в списке строки с длиной 3 символа
            var existsLength3 = people.Exists(p => p.Length == 3);  // true

            // проверяем, есть ли в списке строки с длиной 7 символов
            var existsLength7 = people.Exists(p => p.Length == 7);  // false

            // получаем первый элемент с длиной в 3 символа
            var firstWithLength3 = people.Find(p => p.Length == 3); // Tom

            // получаем последний элемент с длиной в 3 символа
            var lastWithLength3 = people.FindLast(p => p.Length == 3);  // Sam

            // получаем все элементы с длиной в 3 символа в виде списка
            List<string> peopleWithLength3 = people.FindAll(p => p.Length == 3);
            // peopleWithLength3 { "Tom", "Bob", "Sam"}




            /*foreach (var person in people)
            {
                Console.WriteLine(person);
            }*/

        }
    }
}

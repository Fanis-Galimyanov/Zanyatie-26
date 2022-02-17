using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<int, string>()
            {
                [5] = "Tom",
                [6] = "Sam",
                [7] = "Bob",
            };
            // получаем элемент по ключу 6
            string sam = people[6];  // Sam
            Console.WriteLine(sam);  // Sam
                                     // переустанавливаем значение по ключу 6
            people[6] = "Mike";
            Console.WriteLine(people[6]);  // Mike

            // добавляем новый элемент по ключу 22
            people[22] = "Eugene";
            Console.WriteLine(people[22]);  // Eugene

        }
    }

}



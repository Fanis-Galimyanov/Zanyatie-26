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

            // удаляем элементы
            var success1 = people.TryPop(out var person1);  // success1 = true
            if (success1) Console.WriteLine(person1); // Tom

            var success2 = people.TryPeek(out var person2);  // success2 = false
            if (success2) Console.WriteLine(person2);

        }
    }

}



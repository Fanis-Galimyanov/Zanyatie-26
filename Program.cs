using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> people = new LinkedList<string>(new[] { "Tom", "Sam", "Bob" });

            // от начала до конца списка
            var currentNode = people.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

            // с конца до начала списка
            currentNode = people.Last;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Previous;
            }




        }
    }
}

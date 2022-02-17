using System;
using System.Collections.ObjectModel;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new ObservableCollection<string>();

            // добавляем элемент
            people.Add("Bob");
            // вставляем элемент по индексу 0
            people.Insert(0, "Tom");

            // проверка наличия элемента 
            bool bobExists = people.Contains("Bob");     // true
            Console.WriteLine($"Bob exists: {bobExists}");
            bool mikeExists = people.Contains("Mike");   // false
            Console.WriteLine($"Mike exists: {mikeExists}");

            // удаляем элемент
            people.Remove("Tom");
            // удаляем элемент по индексу 0
            people.RemoveAt(0);

           /* people.RemoveAt(0);*/

        }
    }

}



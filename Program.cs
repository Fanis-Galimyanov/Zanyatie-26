using System;
using System.Collections.ObjectModel;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new ObservableCollection<string>
            {
                    "Tom", "Bob", "Sam"
            };

            // получаем первый элемент
            Console.WriteLine(people[0]);   // Tom
                                            // изменяем первый элемент
            people[0] = "Tomas";
            Console.WriteLine(people[0]);   // Tomas





        }
    }

}



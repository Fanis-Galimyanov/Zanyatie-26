using System;
using System.Collections.ObjectModel;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> people1 = new ObservableCollection<string>();

            var people2 = new ObservableCollection<string>(new string[] { "Tom", "Bob", "Sam" });

            var people3 = new ObservableCollection<string>
            {
                "Tom", "Bob", "Sam"
            };

            var people = new ObservableCollection<string>(new string[] { "Mike", "Alice", "Kate" })
            {
            "Tom", "Bob", "Sam"
            };




        }
    }

}



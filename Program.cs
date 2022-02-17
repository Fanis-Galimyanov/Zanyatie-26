using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      Dictionary<int, string> people = new Dictionary<int, string>();*/
            /*       var people = new Dictionary<int, string>()
                   {
                       { 5, "Tom"},
                       { 3, "Sam"},
                       { 11, "Bob"}
                   };*/

            var people = new Dictionary<int, string>()
            {
                [5] = "Tom",
                [6] = "Sam",
                [7] = "Bob"
            };


        }
    }

}



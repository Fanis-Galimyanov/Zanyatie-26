using System;
using System.Collections.Generic;

namespace z25
{
    class Program
    {
        static void Main(string[] args)
        {
            // условная телефонная книга
            var phoneBook = new Dictionary<string, string>();

            // добавляем элемент: ключ - номер телефона, значение - имя абонента
            phoneBook.Add("+123456", "Tom");
            // альтернативное добавление
            // phoneBook["+123456"] = "Tom";

            // Проверка наличия
            var phoneExists1 = phoneBook.ContainsKey("+123456");    // true
            Console.WriteLine($"+123456: {phoneExists1}");
            var phoneExists2 = phoneBook.ContainsKey("+567456");    // false
            Console.WriteLine($"+567456: {phoneExists2}");
            var abonentExists1 = phoneBook.ContainsValue("Tom");      // true
            Console.WriteLine($"Tom: {abonentExists1}");
            var abonentExists2 = phoneBook.ContainsValue("Bob");      // false
            Console.WriteLine($"Bob: {abonentExists2}");

            // удаление элемента
            phoneBook.Remove("+123456");

            // проверяем количество элементов после удаления
            Console.WriteLine($"Count: {phoneBook.Count}"); // Count: 0


        }
    }

}



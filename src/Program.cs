using System;
using System.Collections.Generic;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nName Sorter started");
            Console.WriteLine("------------------------------------\n");

            var fileHandler = new FileHandler();
            var fileContent = fileHandler.ReadFile(args[0]);

            var sorter = new Sorter(fileContent);
            var sorted = sorter.Sorted;
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------\n");

            fileHandler.WriteFile("names-sorted.txt", sorted);
        }
    }
}

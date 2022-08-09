using GrokkingAlgorithms.Algorithms;
using System;
using System.Text;

namespace GrokkingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO look for binary search tree
            //Console.WriteLine("Enter element to search from 1 to 100");
            //var search = Convert.ToInt32(Console.ReadLine());
            //BinarySearch(search);
            SelectionSort();
            Console.ReadKey();
        }

        static void BinarySearch(int itemToSearch)
        {
            var arr = Enumerable.Range(1, 100).ToList(); ;
            var found = new BinarySearch<int>().Run(arr, itemToSearch);
            if (!found.HasValue)
                Console.WriteLine($"Item {itemToSearch} not found");
            else
            {
                Console.WriteLine($"{itemToSearch} founded at index {found}");
            }
        }

        static void SelectionSort()
        {
            Random random = new Random();
            var randomArray = Enumerable.Range(0, 10).Select(x => random.Next(100)).ToArray();
            PrintArray(randomArray);
            var sortedArray = new SelectionSort().Run(randomArray);
            PrintArray(sortedArray);
        }

        static void PrintArray<T>(IEnumerable<T> array)
        {
            array.ToList().ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 3, 5, 9, 4, 1, 9, 3, 6};
            PrintEvensAndOdds(nums);
        }

        static void PrintEvensAndOdds(int[] array)
        {
            var evenNums = new SortedDictionary<int, int>();
            var oddNums = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNums.Add(i, array[i]);
                }

                else
                {
                    oddNums.Add(i, array[i]);
                }
            }

            Console.WriteLine("Even numbers:");
            foreach (var num in evenNums)
            {
                Console.WriteLine($"Index: {num.Key} - Number: {num.Value}");
            }

            var oddNumsOrdered = oddNums.OrderByDescending(n => n.Key);

            Console.WriteLine("Odd numbers:");
            foreach (var num in oddNumsOrdered)
            {
                Console.WriteLine($"Index: {num.Key} - Number: {num.Value}");
            }
        }
    }
}

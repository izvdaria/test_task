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

            Console.WriteLine("*****");

            int n = 20;
            var array = GenerateArray(n);
            GetLongestNumbersSequence(array);
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

        static void GetLongestNumbersSequence(int[] array)
        {
            var dict = new SortedDictionary<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            for (int i = 0; i < array.Length - 1;)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        continue;
                    }

                    var length = j - i;
                    if (!dict.ContainsKey(length))
                    {
                        dict[length] = i;
                    }

                    i = j;
                    break;
                }
            }

            var entry = dict.First();

            Console.WriteLine($"The longest sequence of '{array[entry.Value]}'s: start index:{entry.Value} length:{entry.Key}.");
        }

        static int[] GenerateArray(int n)
        {
            var array = new int[n];
            var rand = new Random(0);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2);
            }

            return array;
        }
    }
}

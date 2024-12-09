using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        string[] lines = File.ReadAllLines("day1.txt");

        foreach (string line in lines)
        {
            // Split each line by spaces or tabs
            string[] numbers = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Add the numbers to their respective lists
            if (numbers.Length == 2)
            {
                list1.Add(int.Parse(numbers[0]));
                list2.Add(int.Parse(numbers[1]));
            }
        }

        list1.Sort();
        list2.Sort();

        List<int> absoluteDifferences = new List<int>();
        for (int i = 0; i < list1.Count; i++)
        {
            int difference = Math.Abs(list2[i] - list1[i]);
            absoluteDifferences.Add(difference);
        }

        int sumOfDifferences = absoluteDifferences.Sum();

        Console.WriteLine("Sum of Absolute Differences: " + sumOfDifferences);
    }
}
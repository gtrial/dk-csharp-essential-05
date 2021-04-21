using System;
using System.Linq;

namespace task02
{
    internal static class Program
    {
        private static void Main()
        {
            var intArray = new[] {1, 2, 5, 4, 6};
            var maxValue = intArray.First();
            foreach (var intValue in intArray)
            {
                if (intValue > maxValue)
                {
                    maxValue = intValue;
                }
            }

            Console.WriteLine($"Max value: {maxValue}");
            var minValue = intArray.First();
            foreach (var intValue in intArray)
            {
                if (intValue < minValue)
                {
                    minValue = intValue;
                }
            }

            Console.WriteLine($"Min value: {minValue}");
            var totalSum = 0;
            foreach (var intValue in intArray)
            {
                totalSum += intValue;
            }

            Console.WriteLine($"Total sum: {totalSum}");
            Console.WriteLine($"Average value: {(double) totalSum / intArray.Length}");
            var oddArrayString = "";
            foreach (var intValue in intArray)
            {
                if (intValue % 2 == 1)
                {
                    oddArrayString += intValue.ToString() + ", ";
                }
            }

            Console.WriteLine($"Odd values: {oddArrayString.TrimEnd(new char[] {',', ' '})}");
        }
    }
}
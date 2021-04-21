using System;

namespace task04
{
    internal static class Program
    {
        private static void Main()
        {
            var store = new Store(new[]
            {
                new Article("item 1", "shop 1", 10),
                new Article("item 2", "shop 2", 20)
            });
            Console.WriteLine("Article index:");
            var articleIndex = int.Parse(Console.ReadLine() ?? string.Empty);
            try
            {
                store[articleIndex].Print();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Article with index {articleIndex} was not found");
            }
        }
    }
}
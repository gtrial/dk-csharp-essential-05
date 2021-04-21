using System;

namespace task04
{
    public class Article
    {
        private readonly string _item;
        private readonly string _shop;
        private readonly decimal _price;

        public Article(string item, string shop, decimal price)
        {
            _item = item;
            _shop = shop;
            _price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Item: {_item}, Shop: {_shop}, Price: {_price}");
        }
    }
}
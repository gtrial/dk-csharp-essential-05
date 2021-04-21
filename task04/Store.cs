namespace task04
{
    public class Store
    {
        private readonly Article[] _articles;

        public Store(Article[] articles)
        {
            _articles = articles;
        }

        public Article this[int index] => _articles[index];
    }
}
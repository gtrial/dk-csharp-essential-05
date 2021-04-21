using System;

namespace task03
{
    internal static class Program
    {
        private static void Main()
        {
            var matrix = new MyMatrix(2, 3);
            matrix.Print();
            matrix.RowCount = 4;
            matrix.ColumnCount = 5;
            matrix.Print();
            matrix.Derivative();
        }
    }
}
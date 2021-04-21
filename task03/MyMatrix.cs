using System;

namespace task03
{
    public class MyMatrix
    {
        private int _rowCount;
        private int _columnCount;

        public int RowCount
        {
            get => _rowCount;
            set
            {
                _rowCount = value;
                Matrix = new int[RowCount, ColumnCount];
            }
        }

        public int ColumnCount
        {
            get => _columnCount;
            set
            {
                _columnCount = value;
                Matrix = new int[RowCount, ColumnCount];
            }
        }

        private int[,] Matrix { get; set; }

        public MyMatrix(int rowCount, int columnCount)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            Matrix = new int[rowCount, columnCount];
        }

        public void Print()
        {
            for (var i = 0; i < RowCount; i++)
            {
                for (var j = 0; j < ColumnCount; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }

                Console.Write($"\n");
            }
        }

        public void Derivative()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Not implemented");
        }
    }
}
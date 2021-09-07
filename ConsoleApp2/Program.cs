using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2 };
            int[] array2 = { 0, 1, 2, 3, 4, 5, 7, 8 };
            int[] array3 = { 0, 1, 2, 3, 4, 5, 7, 8, 9, 10 };
            Console.WriteLine("Hello World!");
            DiagonalMatrix<int> square = new DiagonalMatrix<int>(array, 3);
            TwoDimensionalMatrix<int> twodim = new TwoDimensionalMatrix<int>(array, 3);



            Console.WriteLine(twodim[2, 2]);
        }
    }
}

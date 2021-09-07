using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2 };
            int[] array2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] array3 = { 0, 1, 2, 3, 4, 5, 7, 8, 9, 10 };

            SquareMatrix<int> square = new SquareMatrix<int>(array2, 3);
            
            square.ElementsChanged += PrintToConsole2;
            square.ElementsChanged += (i, j, k, n) => Console.WriteLine($"The matrix elements array has been changed 2 times, at index x {i} y index {j}, old value: {k}, new value: {n}!");
            square[1, 1] = 8;

            DiagonalMatrix<int> diagonal = new DiagonalMatrix<int>(array);
            
            diagonal.ElementsChanged += PrintToConsole2;
            diagonal[0, 0] = 11;
            diagonal[1, 1] = 11;

        }
       
        static void PrintToConsole2<T>(int i, int j, T oldValue, T newValue)
        {
            Console.WriteLine($"!The matrix elements array has been changed at index x {i} y index {j}, old value: {oldValue}, new value: {newValue}!");
        }
    }

}

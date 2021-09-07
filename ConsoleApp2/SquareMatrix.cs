

namespace ConsoleApp2
{

    /// <summary>
    /// Square matrix class inherits TwoDimensionalMatrix
    /// </summary>
    /// <typeparam name="T"> Generic type</typeparam>
    class SquareMatrix<T> : TwoDimensionalMatrix<T>
    {
        public int Dimension { get; }
        /// <summary>
        /// Works for SquareMatrix objects creation only
        /// </summary>
        /// <param name="elements"> array of elements in matrix</param>
        /// <param name="dimension"> X and Y dimension of matrix, because its Square X and Y are equal</param>
        public SquareMatrix( T[] elements, int dimension  ) : base(elements, dimension, dimension )
        {
            Dimension = dimension;
        }
        /// <summary>
        /// Wokrs for child class DiagonalMatrix and connects to base class, passing last ragument as 1()because Diagonal matrix has only 3 elements in array
        /// </summary>
        /// <param name="elements"> Matrix values in array  </param>
        protected SquareMatrix( T[] elements) : base(elements, elements.Length, 1 )
        {
            Dimension = elements.Length;
        }
    }
}
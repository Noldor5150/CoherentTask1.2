using System;

namespace ConsoleApp2
{
   /// <summary>
   /// Diagonal matrix, inherits form SquareMatrix class, has only 3 values in one dimensional array
   /// </summary>
   /// <typeparam name="T">Generic type</typeparam>
    class DiagonalMatrix<T> : SquareMatrix<T>
    {
        public override event MatrixElementsChanged ElementsChanged;

        /// <summary>
        /// works with protected base class constructor, other params goes as array.Length and 1
        /// </summary>
        /// <param name="elements"> Matrix values in array </param>
        public DiagonalMatrix( T[] elements) : base(elements)
        {
           
        }

        /// <summary>
        /// Indexators, works as two dimensional selector for User, but values are stored in one dimensional array
        /// </summary>
        /// <param name="i"> X dimension selector from User perspective </param>
        /// <param name="j"> Y dimension selector from User perspective </param>
        /// <returns></returns>
        public override T this[int i, int j]
        {
            get
            {
                if ( i >= Dimension  || j >= Dimension )
                {
                    throw new IndexOutOfRangeException("These are default values null, empty or zero, you can not change them");
                }
                return   ( i == j && i < Dimension ) ? base[0, i] : default;
                 
            }

            set
            {

                if ( i == j && i < Dimension )
                {
                    if (!base.Equals( value ))
                    {
                        T t = base[0, i];
                        T n = value;
                        ElementsChanged?.Invoke( i, j, t, n );
                    }

                    base[0, i] = value;
                }

                else
                {
                    throw new IndexOutOfRangeException( "These are default values null, empty or zero, you can not change them" );
                }

            }
        }
    }
}

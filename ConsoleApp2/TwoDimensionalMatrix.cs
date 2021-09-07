using System;

namespace ConsoleApp2
{ 
   /// <summary>
   /// BAse class for Square and Diagonal matrixes
   /// </summary>
   /// <typeparam name="T">generic type</typeparam>
    class TwoDimensionalMatrix<T>
    {
        private T[] _matrixElements;
        public int XSize { get; }
        public int Ysize { get; }

        public delegate void MatrixElementsChanged(int i,int j, T oldValue, T newValue);
        
        public  virtual event MatrixElementsChanged ElementsChanged;

        /// <summary>
        /// Base constructor trows exeptions before objet creation
        /// </summary>
        /// <param name="elements"> Matrix values in one dimensional array </param>
        /// <param name="x"> X dimension size of matrix </param>
        /// <param name="y"> Y dimension size of matrix </param>
        public TwoDimensionalMatrix( T[] elements, int x, int y )
        {
            if (( elements == null ) || 
                ( x <= 0 || y <= 0 ) || 
                ( elements.Length != x * y ))
            {
                throw new IndexOutOfRangeException("X and/or Y value must be more than zero!!!");
            }
                _matrixElements = elements;
                XSize = x;
                Ysize = y;
        }

        /// <summary>
        /// Indexators, works as two dimensional selector for User, but values are stored in one dimensional array
        /// </summary>
        /// <param name="i"> X dimension selector from User perspective </param>
        /// <param name="j"> Y dimension selector from User perspective </param>
        /// <returns></returns>
        public virtual T this[ int i, int j ]
        {
            get
            {
                return _matrixElements[ Ysize * i + j ];
            }

            set
            {
                if  ( !_matrixElements[ Ysize * i + j ].Equals(value))
                {
                    T t = _matrixElements[ Ysize * i + j ];
                    T n = value;
                    ElementsChanged?.Invoke( i, j, t, n );
                }
                _matrixElements[Ysize * i + j] = value;
            }

        }
    }
}

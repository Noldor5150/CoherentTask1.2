using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    class DiagonalMatrix<T> : SquareMatrix<T>
    {

        public override T this[int a, int j]
        {
            get
            {
                if (a == j && a < MatrixElements.Length)
                {
                    return MatrixElements[a];
                }
                else
                {
                    throw new IndexOutOfRangeException("These are default values null, empty or zero");
                }

            }

            set
            {

                if (a == j && a < MatrixElements.Length)
                {
                    MatrixElements[a] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("These are default values null, empty or zero, you can not change them");
                }

            }
        }

        public DiagonalMatrix(T[] elements, int x) : base(elements, x)
        {
            if (elements.Length != x)
            {
                throw new IndexOutOfRangeException("Wrong array, not enough elements!!!");
            }

        }

    }
}

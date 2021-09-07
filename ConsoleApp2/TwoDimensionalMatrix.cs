using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TwoDimensionalMatrix<T>
    {
        public T[] MatrixElements { get; set; }
        public int XDimensionLength { get; set; }
        public int YDimensionLenth { get; set; }

        //if( value <= 0 || Math.Sqrt(value) % 1 != 0)


        public virtual T this[int a, int j]
        {
            get
            {
                return MatrixElements[YDimensionLenth * a + j];
            }

            set
            {
                MatrixElements[YDimensionLenth * a + j] = value;
            }

        }

        public TwoDimensionalMatrix(T[] elements, int x)
        {
            if (x <= 0)
            {
                throw new IndexOutOfRangeException("X and/or Y value must be more than zero!!!");
            }
            else
            {
                MatrixElements = elements;
                XDimensionLength = x;
            }
        }
        public TwoDimensionalMatrix(T[] elements, int x, int y)
        {
            if (x <= 0 && y <= 0)
            {
                throw new IndexOutOfRangeException("X and/or Y value must be more than zero!!!");
            }


            else if (elements.Length != x * y)
            {
                throw new IndexOutOfRangeException("X and/or Y value must be more than zero!!!");
            }

            else
            {
                MatrixElements = elements;
                XDimensionLength = x;
                YDimensionLenth = y;
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SquareMatrix<T> : TwoDimensionalMatrix<T>
    {


        public SquareMatrix(T[] elements, int x) : base(elements, x)
        {
            if (elements.Length < x)
            {
                throw new IndexOutOfRangeException("Wrong array, not enough elements!!!");
            }
        }
    }
}
using System;

namespace csnotes
{
    public class ArraySlice2D<T>
    {
        private readonly T[, ] arr;
        private readonly int firstDimension;
        private readonly int length;
        public int Length { get { return length; } }
        public ArraySlice2D (T[, ] arr, int firstDimension) {
            this.arr = arr;
            this.firstDimension = firstDimension;
            this.length = arr.GetUpperBound (1) + 1;
        }
        public T this [int index] {
            get { return arr[firstDimension, index]; }
            set { arr[firstDimension, index] = value; }
        }
    }
}
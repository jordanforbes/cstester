using System;

namespace csnotes
{
static class ArraySliceExt {
    public static ArraySlice2D<T> Slice<T> (this T[, ] arr, int firstDimension) {
        return new ArraySlice2D<T> (arr, firstDimension);
    }
}
}
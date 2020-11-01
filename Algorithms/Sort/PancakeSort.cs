using System;

namespace structures_and_algorithms.Algorithms.Sort
{
    public static class PancakeSort
    {
        static Int32 IndexOfMax(Int32[] arr,Int32 subArrEndI) // Get Index of Max element from subarray
        {
            Int32 res = 0;
            for (int i = 1; i <= subArrEndI; ++i)
            {
                if (arr[i]>arr[res])
                {
                    res = i;
                }
            }
            return res;
        }
        static Int32[] Flip(Int32[] arr, Int32 end)
        {
            for (int start = 0; start < end; start++,end--)
            {
                Swap.Go(ref arr[start],ref arr[end]);
            }
            return arr;
        }
        public static Int32[] Sort(Int32[] arr)
        {
            for (var subArrLength=arr.Length-1; subArrLength>=0; subArrLength--)
            {
                var IndexMax = IndexOfMax(arr,subArrLength);
                if (IndexMax!=subArrLength)
                {
                    Flip(arr,IndexMax);// flip arrray before Max element
                    Flip(arr,subArrLength);// flip array
                }
            }
            return arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
   public static class SelectionSort
    {
        static Int32 IndOfMin(Int32[] arr,Int32 subArrI)
        {
            Int32 res = subArrI;
            for (int i = subArrI; i < arr.Length; ++i)
            {
                if (arr[i]<arr[res])
                {
                    res = i;
                }
            }
            return res;
        }
        public static Int32[] Sort(Int32[] arr, Int32 currInd=0)
        {
            if (currInd==arr.Length)
            {
                return arr;
            }
            var ind = IndOfMin(arr,currInd);
            if (ind!=currInd)
            {
                Swap.Go(ref arr[ind], ref arr[currInd]);
            }
            return Sort(arr,currInd+1);
        }
    }
}

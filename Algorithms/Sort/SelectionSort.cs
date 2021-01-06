using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
   public class SelectionSort:ISort
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
        public static  Int32[] Sorty(Int32[] arr, Int32 currInd=0)
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
            return Sorty(arr,currInd+1);
        }
        public Int32[] Sort(Int32[] arr)
        {
           return Sorty(arr);
        }
    }
}

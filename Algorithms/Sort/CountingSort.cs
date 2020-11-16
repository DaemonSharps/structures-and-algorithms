using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    public static class CountingSort
    {
        public static Int32[] Sort(Int32[] arr, Int32 k)
        {
            var count = new Int32[k + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }
            var ind = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    arr[ind] = i;
                    ind++;
                }
            }
            return arr;
        }
    }
}

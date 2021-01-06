using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    public class InsertionSort:ISort
    {
        public Int32[] Sort(Int32[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var key = arr[i];
                var j = i;
                while ((j>=1)&&(arr[j-1]>key))
                {
                    Swap.Go(ref arr[j-1],ref arr[j]);
                    j--;
                }
                arr[j] = key;
            }
            return arr;
        }
    }
}

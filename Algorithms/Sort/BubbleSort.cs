using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    class BubbleSort
    {
      public  static int[] Sort(int[] arr)
        {
            var length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                for (int j = 0; j < length-i; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        Swap.Go(ref arr[j],ref arr[j+1]);
                    }
                }
            }
            return arr;
        }
    }
}

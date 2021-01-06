using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    public class CountingSort:ISort
    {
        public static Int32[] SortUnc(Int32[] arr, Int32 k)
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
        public Int32[] Sort(Int32[] arr)
        {
            var min = arr[0];
            var max = arr[0];
            foreach (var num in arr)
            {
                if (num>max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
                
            }
            var correction = min != 0 ? -min : 0;
            max += correction;
            var count = new Int32[max + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] + correction]++;
            }
            var index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    arr[index] = i - correction;
                    index++;
                }
            }
            return arr;
        }
    }
}

using System;

namespace structures_and_algorithms.Algorithms.Sort
{
   public static class ShellSort
    {
        public static Int32[] Sort(Int32[] arr)
        {
            var d = arr.Length / 2;// distance between two elements
            while (d>=1)
            {
                for (int i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j>=d)&&(arr[j-d]>arr[j]))
                    {
                        Swap.Go(ref arr[j],ref arr[j-d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return arr;
        }
    }
}

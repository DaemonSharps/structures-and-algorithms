using System;


namespace structures_and_algorithms.Algorithms.Sort
{
    public static class RandomSort
    {
        static bool IsSorted(int[] arr)
        {
            for(int i=0;i<arr.Length-1;i++)
            {
                if (arr[i]>arr[i+1])
                {
                    return false;
                }
            }
            return true;
        }
         static int[] RandPremutation(int[]arr)
        {
            Random rand = new Random();
            var n = arr.Length;
            while (n>1)
            {
                n--;
                var i = rand.Next(n+1);
                Swap.Go(ref arr[i],ref arr[n]);
                
            }
            return arr;
        } 
        public static int[] Sort(int[] arr)
        {
            while (!IsSorted(arr))
            {
                arr = RandPremutation(arr);
            }
            return arr;
        }
    }
}

using System;


namespace structures_and_algorithms.Algorithms.Sort
{
    public static class StoogeSort
    {
        static Int32[] Sort(Int32[] arr,Int32 startI, Int32 EndI)
        {
            if (arr[startI]>arr[EndI])
            {
                Swap.Go(ref arr[startI],ref arr[EndI]);
            }
            if (EndI-startI>1)
            {
                var leng = (EndI - startI + 1) / 3;
                Sort(arr,startI,EndI-leng);
                Sort(arr,startI+leng,EndI);
                Sort(arr,startI,EndI-leng);
            }
            return arr;
        }
        public static Int32[] Sort(Int32[] arr)
        {
            return Sort(arr,0,arr.Length-1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    public class QuickSort:ISort
    {
        static Int32 Patrition(Int32[] arr, Int32 MinI, Int32 MaxI)
        {
            var pivot = MinI - 1;
            for (int i = MinI; i < MaxI; i++)
            {
                if (arr[i] < arr[MaxI])
                {
                    pivot++;
                    Swap.Go(ref arr[i], ref arr[pivot]);
                }
            }
            pivot++;
            Swap.Go(ref arr[pivot],ref arr[MaxI]);
            return pivot;
        }
       static Int32[] Sort(Int32[] arr,Int32 MinI,Int32 MaxI)
        {
            if (MinI>=MaxI)
            {
                return arr;
            }
            var PivotI = Patrition(arr,MinI,MaxI);
            Sort(arr,MinI,PivotI-1);
            Sort(arr,PivotI+1,MaxI);
            return arr;
        }
       public Int32[] Sort(Int32[] arr)
        {
            return Sort(arr,0,arr.Length-1);
        }
    }
}

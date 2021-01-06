using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    public class CombSort:ISort
    { static Int32 GetNextStep(int s)
        {
            s = s * 1000 / 1247;
            return s > 1 ? s : 1;
        }
        public Int32[] Sort(Int32[] arr)
        {
            var arrLeng = arr.Length;
            var currStep = arrLeng - 1;
            while (currStep>1)
            {
                for (int  i = 0;  i+currStep <arrLeng;  i++)
                {
                    if (arr[i]>arr[i+currStep])
                    {
                        Swap.Go(ref arr[i],ref arr[i+currStep]);
                    }
                }
                currStep = GetNextStep(currStep);
            }
             arr=new BubbleSort().Sort(arr);
            return arr;
        }
    }
}

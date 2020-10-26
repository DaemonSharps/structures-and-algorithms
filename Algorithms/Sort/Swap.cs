using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
  public static  class Swap
    {
        public static void Go(ref int a,ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms
{
   public class RandomInt32Array
    {
        Int32[] array;
       public  RandomInt32Array(Int32 numsCount, Int32 min=0, Int32 max=10)
        {
            array=new Int32[numsCount];
            Random rnd = new Random();
            for (Int32 i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
                Console.Write(array[i] + " ");
            }
        }
        public Int32[] Array { get { return array; } }
    }
}

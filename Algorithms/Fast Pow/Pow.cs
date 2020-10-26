using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Fast_Pow
{
    public static class Pow
    {
        public static double Recursive(double number,int degree)
        {
            if (degree == 0)
                return 1;
            if (degree%2==0)
            {
                var p = Recursive(number, degree / 2);
                return p * p;
            }
            else
            {
                return number * Recursive(number,degree-1);
            }
        }
        public static double Byte(double number, int degree)
        {
            if (degree == 0)
                return 1;
            if ((degree&1)==0)// последний бит равен 0 - четное число
            {
                var p = Byte(number,degree>>1);//смещение на один бит как деление на два
                return p * p;
            }
            else
            {
                return number * Byte(number,degree-1);
            }
        }
        public static double Iter(double number, int degree)
        {
            var res = 1D;
            while (degree>0)
            {
                if ((degree&1)==0)
                {
                    number *= number;
                    degree >>= 1;
                }
                else
                {
                    res *= number;
                    --degree;

                }
            }
            return res;
        }
    }
}

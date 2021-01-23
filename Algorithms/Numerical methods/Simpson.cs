using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Numerical_methods
{/// <summary>
/// Суть метода заключается в приближении подынтегральной функции на отрезке [a, b] интерполяционным многочленом второй степени p2(x), то есть приближение графика функции на отрезке параболой.
/// </summary>
    public static class Simpson
    {/// <summary>
    /// Метод подсчета интеграла
    /// </summary>
    /// <param name="f">Подинтегральная функция</param>
    /// <param name="a">Начало отрезка интегрирования</param>
    /// <param name="b">Конец отрезка интегрирования</param>
    /// <param name="n">Шаг интегрирования</param>
    /// <returns></returns>
        public static double Integral(Func<double,double>f,double a, double b,int n=1000)
        {
            var h = (b - a) / n;
            var sum_1 = 0d;
            var sum_2=0d;
            for (int i = 1; i <= n; i++)
            {
                var xk = a + i * h;//чередующиеся границы и середины составных отрезков, на которых применяется формула Симпсона
                if (i<=n-1)
                {
                    sum_1 += f(xk);
                }
                var xk_1 = a + (i-1) * h;
                sum_2 += f((xk + xk_1) / 2);
            }
            var res = h / 3d * (1d / 2d * f(a) + sum_1 + 2 * sum_2 + 1d / 2d * f(b));
            return res;

        }
    }
}

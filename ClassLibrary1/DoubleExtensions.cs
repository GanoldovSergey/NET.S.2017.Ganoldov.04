using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MathExtensions
    {
        /// <summary>
        /// Newton's algorithm for getting n-th root of number.
        /// </summary>
        /// <param name="a">A number to get root</param>
        /// <param name="n">Root power</param>
        /// <param name="eps">Accuracy</param>
        /// <returns> N-th root of 'a'</returns>
        public static double Root(double a, int n, double eps = 0.0001)
        {
            if (a <= 0) throw new ArgumentException($"{nameof(a)} must be positive");
            if (n < 1) throw new ArgumentException($"{nameof(n)} must be greater than 0");
            if (eps < 0) throw new ArgumentException($"{nameof(eps)} must be positive");

            double x0 = a / n;
            double x1 = (1.0 / n) * ((n - 1) * x0 + a / Math.Pow(x0, n - 1));

            while (Math.Abs(x0 - x1)> eps)
            {
                x0 = x1;
                x1 = (1.0 / n) * ((n - 1) * x0 + a / Math.Pow(x0, n - 1));
            }

            return x1;
        }
    }
}

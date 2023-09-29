using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2
{
    static class Tasks
    {
        public static int Task1()
        {
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static double Task2(int hours, int minutes)
        {
            var angleHours = (hours % 12 * 30) + (double)minutes / 2;
            var angleMinutes = minutes * 6;
            return Math.Abs(angleHours - angleMinutes);
        }

        public static int[] Task3(int h, int t, int v, int x)
        {
            // | t1 + t2 = t
            // |                     => t1 = t - t2 => 
            // | x * t1 + v * t2 = h
            //
            // => x * (t - t2) + v * t2 = h => 
            // => t2 = (h - x * t) / (v - x)

            var t2 = (h - x * t) / (v - x);
            var t1 = t - t2;
            var tMin = Math.Min(t2, t1);


            // V * tMax = h
            // tMax = h / V
            // x < V < v
            // tMax <= t
            
            for (int tMax = t; tMax >= 1; tMax--)
            {
                double V = h / tMax;
                if ((x<V) && (V < v))
                {
                    return new int[] { tMin, tMax };
                }
            }
            return new int[] { tMin, 0 };
        }
        public static double Task4(double r, double a)
        {
            var squareDiagonal = a * Math.Pow(2, 0.5);
            if (r * 2 <= a)
            {
                return Math.PI * r * r;
            }

            if (squareDiagonal < r)
            {
                return a * a;
            }
            var triangularSquare = Math.Sin(Math.Acos(a / (2 * r))) * 0.5 * r * a;
            var sectorsAngle = 2 * Math.PI - Math.Acos(a / (2 * r)) * 8;
            var sectorsSquare = r * r * sectorsAngle * 0.5;
            return sectorsSquare + triangularSquare * 4;
        }
    }
}

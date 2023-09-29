using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2
{
    internal class Tasks
    {
        public int Task1()
        {
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if ((i%3 == 0) || (i%5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }
        public double Task2()
        {
            var hours = 20;
            var minutes = 56;
            var angleH = (hours % 12 * 30) + minutes / 2;
            var angleM = minutes % 60 * 6;
            return Math.Abs(angleH - angleM);
        }
        public void Task3()
        {
            int h = 10000;
            int T = 500;
            int v = 50;
            int x = 10;
            int midlev = h / T;
            // x * T + V * (T - t) = h
            int tmin = 0;
            while(x * tmin + v * (T - tmin) > h)
            {
                tmin++;
            }
            Console.WriteLine(T - tmin);
            int tmax = T;
            while ((x + 1) * (T - tmax)  + v * tmax < h)
            {
                tmax--;
            }
            Console.WriteLine(tmax);
            
        }
        
        public double Task4()
        {
            double r = 2;
            double a = 5;
            var squareDiagonal = a * Math.Pow(2, 0.5);
            if (r * 2 <= a)
            {
                return Math.PI * r * r;
            }

            if (squareDiagonal < r)
            {
                return a * a;
            }

            var triangularSquare = Math.Sin( Math.Acos(a / (2 * r))) * 0.5 * r * a ;
            var sectorsAngle = 2*Math.PI - Math.Acos(a / (2 * r)) * 8;
            var sectorsSquare = r * r * sectorsAngle * 0.5;
            return sectorsSquare + triangularSquare*4;

        }
    }
}

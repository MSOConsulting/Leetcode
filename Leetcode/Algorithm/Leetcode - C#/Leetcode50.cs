using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/26/2022
 * @updated on: 01/26/2022
 * @description: Implement pow(x,n) which calculates x raised to the power n.
 */

namespace Leetcode
{
    internal class Leetcode50
    {
        public double MyPow(double x, int n)
        {
            long p = (long)n;

            if(p<0)
            {
                p = -p;
                x = 1 / x;
            }

            double res = 1;

            while(p>0)
            {
                if (p % 2 != 0)
                    res *= x;
                p = p / 2;
                x = x * x;
            }

            return res;
        }
    }
}

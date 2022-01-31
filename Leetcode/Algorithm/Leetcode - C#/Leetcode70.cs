using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/31/2022
 * @updated on: 01/31/2022
 * @description: We are climbing a staircase. It takes n steps to reach the top.
                 Each time we can either climb 1 or 2 steps. Let's see in how many distinct ways can we climb to the top.
 */


namespace Leetcode
{
    internal class Leetcode70
    {
        public int ClimbStairs(int n)
        {
            int a = 0, b = 1, res = 1;
            
            for(int i= 0; i < n; i++)
            {
                res = a + b;
                a = b;
                b = res;
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Leetcode70 ltc70 = new Leetcode70();
            int ans = ltc70.ClimbStairs(5);
            Console.WriteLine($"ans is: {ans}");
            Console.Read();
        }
    }
}

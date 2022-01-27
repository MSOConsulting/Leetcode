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

            Leetcode287 ltc287 = new Leetcode287();
            int ans = ltc287.FindDuplicate(new int[] { 5, 3, 4, 5, 2, 1 });
            Console.WriteLine($"ans is: {ans}");
            Console.Read();
        }
    }
}

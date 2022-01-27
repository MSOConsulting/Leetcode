using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/21/2022
 * @updated on: 01/21/2022
 * @description: Given a string s representing a valid expression, implement a basic calculator to evaluate it
 *               and return the result of the evaluation.
 */


namespace Leetcode
{
    internal class Leetcode224
    {
        public int Calculate(String s)
        {
            Stack<int> nb = new Stack<int>();
            int num = 0;
            int result = 0;
            int sign = 1;
             
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    int j = i;
                    while (j < s.Length && Char.IsDigit(s[j]))
                    {
                        num = num * 10 + (s[j] - '0');
                        j++;
                    }
                    i = j - 1;
                }
                if (s[i] == '+')
                { 
                    result += num * sign;
                    sign = 1;
                    num = 0;
                }
                if (s[i] == '-')
                {
                    result += num * sign;
                    sign = -1;
                    num = 0;
                }
                if (s[i] == '(')
                {
                    nb.Push(result);
                    nb.Push(sign);
                    result = 0;
                    sign = 1;
                }
                if (s[i] == ')')
                {
                    result += num * sign;
                    num = result;
                    sign = nb.Pop();
                    result = nb.Pop();
                }
            }
            result += sign * num;

            return result;
        }
    }
}

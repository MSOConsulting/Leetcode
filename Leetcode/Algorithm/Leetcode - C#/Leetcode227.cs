using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/27/2022
 * @updated on: 01/27/2022
 * @description: Given a string s which represents an expression, evaluate this expression and return its value. 
 *               eg: " -3  +  2* 2"
 */

namespace Leetcode
{

    internal class Leetcode227
    {
        public int Calculate(string s)
        {
            int numberToStack = 0;
            char op = '+';
            Stack<int> stackOfNumbers =  new Stack<int>();
            
            for(int i = 0; i < s.Length; i++)
            {
                if (Char.IsWhiteSpace(s[i]))
                    continue;

                if (Char.IsDigit(s[i]))
                    numberToStack = numberToStack * 10 + s[i] - '0';

                if(!Char.IsDigit(s[i]) || i == s.Length - 1)
                {
                    if (op == '+')
                        stackOfNumbers.Push(numberToStack);
                    else if (op == '-')
                        stackOfNumbers.Push(-numberToStack);
                    else if (op == '*')
                        stackOfNumbers.Push(stackOfNumbers.Pop() * numberToStack);
                    else if (op == '/')
                        stackOfNumbers.Push(stackOfNumbers.Pop() / numberToStack);

                    op = s[i];
                    numberToStack = 0;
                }
            }

            int res = 0;
            while(stackOfNumbers.Count>0)
                res += stackOfNumbers.Pop();
            

            return res;
        }
    }
}

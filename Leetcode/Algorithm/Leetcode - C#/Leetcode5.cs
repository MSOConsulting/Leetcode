using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/21/2022
 * @updated on: 01/21/2022
 * @description: Given a string s, return the longest palindromic substring in s.
 */

namespace Leetcode
{
    internal class Leetcode5
    {
        string res = string.Empty;
        int currentSize = int.MinValue;

        public string LongestPalindrome(string s)
        {
            int l = 0, r = 0;
            
            for(int i=0; i<s.Length; i++)
            {
                //Odd
                l = r = i;
                res = SaveLongestPalindrome(l, r, s);

                //Even
                l = i;
                r = i + 1;
                res = SaveLongestPalindrome(l, r, s);
            }

            return res;
        }

        public string SaveLongestPalindrome(int l, int r, string s)
        {
            while(l>=0 && r<s.Length && s[l] == s[r]) 
            {
                currentSize = r - l + 1;
                if (currentSize > res.Length)
                {
                    res = s.Substring(l, currentSize);
                }
                l--;
                r++;
            }

            return res;
        }
    }
}

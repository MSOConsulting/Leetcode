using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class Leetcode76
    {
        public string MinWindow(string s, string t)
        {
            if (s == null || t == null || s == "" || t == "")
                return string.Empty;

            Dictionary<char, int> map = new Dictionary<char, int>();
            bool found = false;

            for (int x = 0; x < t.Length; x++)
            {
                if (map.ContainsKey(t[x]))
                {
                    map[t[x]] += 1;
                }
                else
                    map.Add(t[x], 1);
            }

            int i = 0, j = 0, left = 0, right = 0;
            int min = s.Length;
            int count = map.Count;

            while (j < s.Length)
            {

                char endChar = s[j++];
                if (map.ContainsKey(endChar))
                {
                    map[endChar]--;
                    if (map[endChar] == 0)
                        count--;
                }

                if (count > 0)
                    continue;

                while (count == 0)
                {
                    char startChar = s[i++];
                    if (map.ContainsKey(startChar))
                    {
                        map[startChar]++;
                        if (map[startChar] > 0)
                            count++;
                    }
                }

                if ((j - i) < min)
                {
                    left = i;
                    right = j;
                    min = j - i;
                    found = true;
                }
            }

            return found ? s.Substring(left - 1, right - left + 1) : "";
        }
    }
}

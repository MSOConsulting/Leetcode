using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Leetcode6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1)
                return s;

            List<StringBuilder> strings = new List<StringBuilder>();
            for (int i = 0; i < numRows; i++)
                strings.Add(new StringBuilder());

            int indexer = 0;
            bool reverse = false;
            for (int i = 0; i < s.Length; i++)
            {
                strings[indexer].Append(s[i]);

                if (indexer == numRows - 1)
                    reverse = true;
                else if (indexer == 0)
                    reverse = false;

                if (reverse)
                    indexer--;
                else
                    indexer++;
            }

            for (int i = 1; i < numRows; i++)
                strings[0].Append(strings[i].ToString());

            return strings[0].ToString();
        }
    }
}

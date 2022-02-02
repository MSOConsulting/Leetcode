using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Leetcode49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> toReturn = new List<IList<string>>();
            Dictionary<string, List<string>> dicoStr = new Dictionary<string, List<string>>();


            foreach (string s in strs)
            {
                if (!dicoStr.ContainsKey(sortStr(s)))
                {
                    List<string> lst = new List<string>();
                    lst.Add(s);
                    dicoStr.Add(sortStr(s), lst);

                }
                else
                    dicoStr[sortStr(s)].Add(s);
            }

            foreach (var kvp in dicoStr)
            {
                toReturn.Add(kvp.Value);
            }

            return toReturn;
        }

        public string sortStr(string s)
        {
            return String.Concat(s.OrderBy(c => c));
        }
    }
}

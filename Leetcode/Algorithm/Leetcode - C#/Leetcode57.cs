using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 02/04/2022
 * @updated on: 02/04/2022
 * @description:  array of non-overlapping intervals intervals,Insert newInterval into intervals such that intervals is still sorted in ascending order
 * and still does not have any overlapping intervals (merge overlapping intervals if necessary).
 */

namespace Leetcode
{
    internal class Leetcode57
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (intervals.Length == 0)
                return new int[][] { newInterval };

            var toReturn = new List<int[]>();
            
            foreach (var interval in intervals)
            {
                //newInterval first
                if(newInterval[1] < interval[0])
                {
                    toReturn.Add(newInterval);
                    newInterval = interval;
                }

                //interval first
                else if(newInterval[0] > interval[1])                
                    toReturn.Add(interval);

                //new interval in between
                else 
                {
                    newInterval[0] = Math.Min(newInterval[0], interval[0]); 
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                }
            }

            toReturn.Add(newInterval);

            return toReturn.ToArray();
        }
    }
}

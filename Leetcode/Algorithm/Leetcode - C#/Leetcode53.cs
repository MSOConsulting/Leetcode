using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 02/02/2022
 * @updated on: 02/02/2022
 * @description: Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
 */

namespace Leetcode
{
    internal class Leetcode53
    {
        public int MaxSubArray(int[] nums)
        {
            int maxCount = Int32.MinValue;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                count += nums[i];
                maxCount = Math.Max(count, maxCount);
                if (count < 0)
                    count = 0;
            }

            return maxCount;
        }
    }
}

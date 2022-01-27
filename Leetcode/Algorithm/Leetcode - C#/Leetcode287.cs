using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/28/2022
 * @updated on: 01/28/2022
 * @description: Given an array of integers nums containing n + 1 integers 
 *               where each integer is in the range [1, n] inclusive.
 *               There is only one repeated number in nums, return this repeated number.
 */

namespace Leetcode
{
    internal class Leetcode287
    {
        public int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[nums[0]];

            while(slow != fast)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }

            fast = 0;

            while(slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}

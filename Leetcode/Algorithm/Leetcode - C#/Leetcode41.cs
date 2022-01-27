using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/26/2022
 * @updated on: 01/26/2022
 * @description: Given an unsorted array nums, return the smallest missing positive integer.
 */

namespace Leetcode
{
    internal class Leetcode41
    {
        public int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            for(int i = 0; i < nums.Length; i++)
            {
                while(nums[i]>0 && nums[i]<n && nums[nums[i]-1] != nums[i])
                {
                    Swap(i, nums[i] - 1, nums);
                }
            }
            
            for (int i = 0; i < n; i++) 
            {
                if (nums[i] != i + 1)
                    return i + 1;
            } 

            return n+1;
        }

        private void Swap(int i, int j, int [] nums)
        {
            int aux = nums[i];
            nums[i] = nums[j];
            nums[j] = aux;
        }
    }
}

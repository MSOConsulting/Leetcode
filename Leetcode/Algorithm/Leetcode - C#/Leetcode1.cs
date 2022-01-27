/**
 * @author: Mehdi SOULA
 * @created on: 01/21/2022
 * @updated on: 01/26/2022
 * @description: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class Leetcode1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> dico = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++){
                int complement = target - nums[i];
                
                if (dico.ContainsKey(complement))
                {
                    return new int[]{dico[complement],i};
                }

                dico.Add(nums[i],i);
            }
            return null;
        }
    }
}

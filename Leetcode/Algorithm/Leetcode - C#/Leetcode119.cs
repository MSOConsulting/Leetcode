using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @author: Mehdi SOULA
 * @created on: 01/26/2022
 * @updated on: 01/26/2022
 * @description: Given an integer rowIndex, return the rowIndex th  (0-indexed) row of the Pascal's triangle.
 */

namespace Leetcode
{
    internal class Leetcode119
    {
        public IList<int> GetRow(int rowInt)
        {
            int [] arr = new int[rowInt+1];
            for(int i =0;i<arr.Length;i++)
            {
                arr[i] = 1;
            }

            for(int j=1;j<arr.Length-1;j++)
            {
                for(int k =j;k>0; k--)
                {
                    arr[k] = arr[k]+arr[k-1];
                }
            }

            return arr.ToList();
        }
    }
}

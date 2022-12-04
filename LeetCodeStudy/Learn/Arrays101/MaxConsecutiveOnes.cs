using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStudy.Learn.Arrays101
{
    public class MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    if (max < count)
                        max = count;
                }
                else
                {
                    count = 0;
                }

            }
            return max;
        }
    }
}

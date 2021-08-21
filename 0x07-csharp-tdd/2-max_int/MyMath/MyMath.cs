using System;
using System.Collections.Generic;
namespace MyMath
{
    /// <summary>
    /// Max int in A list
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Max int in a list
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }
            int max = nums[0];
            foreach(var elem in nums)
            {
                if (max < elem)
                {
                    max = elem;
                }
            }
            return max;
        }
    }
}

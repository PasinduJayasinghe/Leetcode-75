using System;

namespace MaximumSubArray
{
    public class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxSubArray(new int[] { 2, -3, 5, -4, 6, 9, -2 }));
        }

        public static int MaxSubArray(int[] nums)
        {
            int maxSub = nums[0];
            int currentSum = 0;

            foreach (int x in nums) {
                if (currentSum < 0) {
                    currentSum = 0;
                    

                }
                currentSum = currentSum + x;
                maxSub = Math.Max(maxSub, currentSum);
            }

            return maxSub;
        }
    }
}

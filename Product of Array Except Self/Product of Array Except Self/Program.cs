using System;

namespace ProductofArrayExceptSelf
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 4, 5, 6 };
            int[] result = ProductExceptSelf(nums);

            Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            // Initialize with 1
            for (int i = 0; i < n; i++)
            {
                result[i] = 1;
            }

            // Build prefix products
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }

            // Build suffix products
            int rightProduct = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                rightProduct *= nums[i + 1];
                result[i] *= rightProduct;
            }

            return result;
        }
    }
    
}
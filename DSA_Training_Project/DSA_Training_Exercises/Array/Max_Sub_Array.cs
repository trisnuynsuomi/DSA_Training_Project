namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class maxSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int currentSum = nums[0];
            int maxSum = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            Console.WriteLine($"Max Sub Array: {{ {maxSum} }}");
            return maxSum;
        }
    }
}
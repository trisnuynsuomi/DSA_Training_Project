namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class runningSumOf1DArray
    {
        public int[] RunningSum(int[] nums)
        {
           int[] result = new int[nums.Length];
           result[0] = nums[0];
           for(int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i] + result[i - 1];
            }
            return result;
        }
    }
}
namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class findMax
    {
        public int FindMax(int[] nums)
        {
            int max = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
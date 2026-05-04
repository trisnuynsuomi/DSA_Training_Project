namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class concatenationArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
                ans[i + n] = nums[i];
            }
            return ans;
        }
    }
}
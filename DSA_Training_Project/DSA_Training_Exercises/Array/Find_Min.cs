namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class findMin
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 0)
            {
                throw new ArgumentException();
            }
            int min = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            return min;
        }
    }
}
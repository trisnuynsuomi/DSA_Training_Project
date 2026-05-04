using System.Globalization;

namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class maxConsecutiveOnes
    {
        public int MaxConsecutiveOnes(int[] nums)
        {
            int current = 0;
            int max = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    current++;
                    max = Math.Max(max, current);
                } else
                {
                    current = 0;
                }
            }

            return max;
        }

    }
}
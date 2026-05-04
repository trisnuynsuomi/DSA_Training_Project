namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class twoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int competent = target - nums[i];
                if(map.ContainsKey(competent))
                {
                    return new int[] {map[competent], i};
                }
                map[nums[i]] = i;
            }
            return new int[] {};
        }
    }
}
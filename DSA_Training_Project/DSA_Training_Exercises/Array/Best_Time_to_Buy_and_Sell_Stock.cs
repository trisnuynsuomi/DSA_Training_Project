using System.Globalization;

namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class bestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int max = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < min)
                {
                    min = prices[i];
                } else
                {
                    int profit = prices[i] - min;
                    if (profit > max)
                    {
                        max = profit;
                    }
                }
            }
            return max;
        }
    }
}
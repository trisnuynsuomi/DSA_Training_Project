using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace DSA_Training_Project.DSA_Training_Exercises.Array
{
    public class maxProfit
    {
        public int MaxProfit(int[] prices)
        {
            int min = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                } else
                {
                    int profit = prices[i] - min;
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }
            return maxProfit;
        }
    }
}
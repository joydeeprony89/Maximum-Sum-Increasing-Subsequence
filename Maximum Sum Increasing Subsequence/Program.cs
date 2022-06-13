using System;
using System.Linq;

namespace Maximum_Sum_Increasing_Subsequence
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { 1, 200, 2, 3, 100, 4, 5 };
      Solution sol = new Solution();
      var msis = sol.MaxSumSubsequence(nums);
      Console.WriteLine($"maximum sum increased subsequence = {msis}");
    }
  }

  public class Solution
  {
    public int MaxSumSubsequence(int[] nums)
    {
      int[] maxdp = new int[nums.Length];

      for (int i = 0; i < maxdp.Length; i++)
        maxdp[i] = nums[i];

      for (int i = nums.Length - 1; i >= 0; i--)
      {
        for (int j = i + 1; j < nums.Length; j++)
        {
          if(nums[i] < nums[j] && maxdp[i] < maxdp[j] + nums[i])
          {
            maxdp[i] = maxdp[j] + nums[i];
          }
        }
      }

      return maxdp.Max();
    }
  }
}

/*

LeetCode 4594
Maximum Average Subarray I
Course: Data Structures and Algorithms

You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value.
Any answer with a calculation error less than 10^-5 will be accepted.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input = [1, 12, -5, -6, 50, 3];
        int k = 4;

        double output = FindMaxAverage(input, k);

        Console.WriteLine("input: " + IntArrayToString(input));
        Console.WriteLine("result: " + output);

    }

    public static double FindMaxAverage(int[] nums, int k) {

        int maxSum = 0;
        int left = 0, right = 0;

        while (right < k)
            maxSum += nums[right++];

        int curSum = maxSum;

        while (right < nums.Length)
        {
            curSum = curSum + nums[right] - nums[left];
            if (curSum > maxSum)
                maxSum = curSum;

            ++left;
            ++right;
        }
        
        return (maxSum*1.0)/(k*1.0);
    }

    public static string IntArrayToString(int[] nums) {

        StringBuilder sb = new StringBuilder();

        sb.Append('[');

        for (int i = 0; i < nums.Length; i++)
        {
            sb.Append(nums[i]);
            if (i < nums.Length - 1)
                sb.Append(", ");
        }

        sb.Append(']');

        return sb.ToString();

    }
}
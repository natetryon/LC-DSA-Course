/*

LeetCode 4658
Running Sum of 1d Array
Course: Data Structures and Algorithms

Given an array nums. We define a running sum of an array as

runningSum[i] = sum(nums[0] ... nums[i])

Return the running sum of nums.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input = [3, 1, 2, 10, 1];

        int[] output = RunningSum(input);

        Console.WriteLine("Input: " + IntArrayToString(input));
        Console.WriteLine("Output: " + IntArrayToString(output));

    }

    public static int[] RunningSum(int[] nums) {

        int len = nums.Length;

        int[] result = new int[len];

        result[0] = nums[0];

        for (int i = 1; i < len; ++i)
            result[i] = nums[i] + result[i - 1];
        

        return result;

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
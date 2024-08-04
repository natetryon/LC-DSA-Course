/*

LeetCode 4657
Minimum Value to Get Positive Step by Step Sum
Course: Data Structures and Algorithms

Given an array of integers nums, you start with an initial positive value startValue.

In each iteration, you calculate the step by step sum of startValue plus elements in nums (from left to right).

Return the minimum positive value of startValue such that the step by step sum is never less than 1.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input1 = [-3,2,-3,4,2];
        // expected output: 5

        int[] input2 = [1,2];
        // expected output: 1

        int[] input3 = [1, -2, -3];
        // expected output: 5


        Console.WriteLine("Input 1: " + IntArrayToString(input1));
        Console.WriteLine("Output: " + MinStartValue(input1));
        Console.WriteLine();

        Console.WriteLine("Input 2: " + IntArrayToString(input2));
        Console.WriteLine("Output: " + MinStartValue(input2));
        Console.WriteLine();

        Console.WriteLine("Input 3: " + IntArrayToString(input3));
        Console.WriteLine("Output: " + MinStartValue(input3));

    }

    public static int MinStartValue(int[] nums) {

        int min = 0, stepSum = 0;

        for (int i = 0; i < nums.Length; ++i)
        {
            stepSum += nums[i];
            min = Math.Min(min, stepSum);
        }


        return 1 - min;

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
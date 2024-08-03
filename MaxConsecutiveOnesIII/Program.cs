/*

LeetCode 4595
Max Consecutive Ones III
Course: Data Structures and Algorithms

Given a binary array nums and an integer k,
return the maximum number of consecutive ones in the array if you can flip at most k zeroes.

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input = [1,1,1,0,0,0,1,1,1,1,0];
        int k = 2;
        // expected output: 6

        int[] input2 = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1];
        int k2 = 3;
        // expected output: 10

        Console.WriteLine("nums = " + IntArrayToString(input) + ", k = " + k);
        Console.WriteLine("output: " + LongestOnes(input, k));

        Console.WriteLine();
        Console.WriteLine("nums2 = " + IntArrayToString(input2) + ", k2 = " + k2);
        Console.WriteLine("output: " + LongestOnes(input2, k2));


    }
 
    public static int LongestOnes(int[] nums, int k) {

        int result = 0, sum = 0, left = 0, right = 0;

        while (right < nums.Length)
        {

            sum += nums[right];

            if (sum > right - left - k) {

                ++right;
                result = Math.Max(result, right - left);
            }

            else {
                sum -= nums[left];
                ++left;
            }
        }
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
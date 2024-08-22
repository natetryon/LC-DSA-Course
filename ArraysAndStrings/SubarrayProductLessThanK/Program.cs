/*

LeetCode 713
Subarray Product Less Than K
Course: Data Structures and Algorithms

Given an array of integers nums and an integer k, return the number of
contiguous subarrays where the product of all the elements in the subarray
is strictly less than k.

Constraints:

1 <= nums.length <= 3x10^4
1 <= nums[i] <= 1000
0 <= k <= 1x10^6

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input1 = [10, 5, 2, 6];
        int k1 = 100;
        // expected output: 8

        int[] input2 = [1, 2, 3];
        int k2 = 0;
        // expected output: 0


        Console.WriteLine("Input 1: " + IntArrayToString(input1) + ", k = " + k1);
        Console.WriteLine("Output: " + NumSubarrayProductLessThanK(input1, k1));
        Console.WriteLine();

        Console.WriteLine("Input 2: " + IntArrayToString(input2) + ", k = " + k2);
        Console.WriteLine("Output: " + NumSubarrayProductLessThanK(input2, k2));


    }

    public static int NumSubarrayProductLessThanK(int[] nums, int k) {

        if (k <= 1)
            return 0;

        int result = 0, left = 0, curr = 1;

        for (int right = 0; right < nums.Length; ++right)
        {
            curr *= nums[right];
            while (curr >= k)
            {
                curr /= nums[left];
                ++left;
            }

            result += right - left + 1;
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
/*
    LeetCode 209
    Minimum Size Subarray Sum (Medium)

    Given an array of positive integers nums and a positive integer target,
    return the minimal length of a subarray whose sum is greater than
    or equal to target. If there is no such subarray, return 0 instead.

    Constraints:

    1 <= target <= 10^9
    1 <= nums.length <= 10^5
    1 <= nums[i] <= 10^4

    Follow up: If you have figured out the O(n) solution, try coding another solution of which the time complexity is O(n log(n)).

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input1 = [2, 3, 1, 2, 4, 3];
        int target1 = 7;
        // output: 2

        int[] input2 = [1, 4, 4];
        int target2 = 4;
        // output: 1

        int[] input3 = [1, 1, 1, 1, 1, 1, 1, 1];
        int target3 = 11;
        // output: 0


        Console.WriteLine("input 1: " + IntArrayToString(input1) + ", target = " + target1);
        Console.WriteLine("output 1: " + MinSubArrayLen(target1, input1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + IntArrayToString(input2) + ", target = " + target2);
        Console.WriteLine("output 2: " + MinSubArrayLen(target2, input2));
        Console.WriteLine();

        Console.WriteLine("input 3: " + IntArrayToString(input3) + ", target = " + target3);
        Console.WriteLine("output 3: " + MinSubArrayLen(target3, input3));
        Console.WriteLine();

    }

    public static int MinSubArrayLen(int target, int[] nums) {

        int left = 0, right = 0, sum = 0;
        int len = nums.Length;
        int min = 2*len;

        while (right < len)
        {
            sum += nums[right];

            while (sum >= target)
            {
                if (nums[right] >= target)
                    return 1;
                min = Math.Min(min, right - left + 1);
                sum -= nums[left++];
            }

            ++right;
        }

        return min > len? 0 : min;
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
/*
    LeetCode 4602
    Missing Number (easy)

    Given an array nums containing n distinct numbers in the range [0, n],
    return the only number in the range that is missing from the array.

    Constraints:

    n == nums.length
    1 <= n <= 10^4
    0 <= nums[i] <= n
    All of the numbers of nums are unique.

    Follow up: Could you implement a solution using only O(1) extra space complexity
    and O(n) runtime complexity?
*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] input1 = [3, 0, 1];
        // output: 2

        int[] input2 = [0, 1];
        // output: 2

        int[] input3 = [9, 6, 4, 2, 3, 5, 7, 0, 1];
        // output: 8

        Console.WriteLine("input 1: " + IntArrayToString(input1));
        Console.WriteLine("output 1: " + MissingNumber(input1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + IntArrayToString(input2));
        Console.WriteLine("output 2: " + MissingNumber(input2));
        Console.WriteLine();

        Console.WriteLine("input 3: " + IntArrayToString(input3));
        Console.WriteLine("output 3: " + MissingNumber(input3));
        Console.WriteLine();



    }

    public static int MissingNumber(int[] nums) {

        int n = nums.Length;
        int sum = (n * (n + 1)) / 2;
        
        for (int i = 0; i < n; ++i)
            sum -= nums[i];
        
        return sum;
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
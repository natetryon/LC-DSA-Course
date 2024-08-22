/*
    LeetCode 4689
    Squares of a Sorted Array
    Course: Data Structures and Algorithms

    Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number
    in non-decreasing order.

*/

using System.Text;

internal class Program {
    public static void Main(string[] args) {

        int[] input = [-7, -3, 2, 3, 11];

        Console.WriteLine("input: " + IntArrayToString(input));
        input = SortedSquares(input);
        Console.WriteLine("output: " + IntArrayToString(input));


    }

    public static int[] SortedSquares(int[] nums) {
        int[] result = new int[nums.Length];

        int left = 0;
        int right = nums.Length - 1;
        int i = right;

        while (left < right)
        {
            if (nums[left]*nums[left] < nums[right]*nums[right])
            {
                result[i] = nums[right]*nums[right];
                --right;
            }

            else
            {
                result[i] = nums[left]*nums[left];
                ++left;
            }

            --i;
        }

        result[i] = nums[right]*nums[right];

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
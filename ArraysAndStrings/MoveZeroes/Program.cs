/*
    LeetCode 283
    Move Zeroes (easy)

    Given an integer array nums, move all 0's to the end of it while maintaining
    the relative order of the non-zero elements.

    Note that you must do this in-place without making a copy of the array.

    Constraints:

    1 <= nums.length <= 10^4
    -2^31 <= nums[i] <= 2^31 - 1

*/

using System.Text;

internal class Program {
    public static void Main(string[] args) {

        int[] input1 = [0, 1, 0, 3, 12];
        int[] input2 = [0];

        Console.WriteLine("input: " + IntArrayToString(input1));
        MoveZeroes(input1);
        Console.WriteLine("output: " + IntArrayToString(input1));
        Console.WriteLine();

        Console.WriteLine("input: " + IntArrayToString(input2));
        MoveZeroes(input2);
        Console.WriteLine("output: " + IntArrayToString(input2));


    }

    public static void MoveZeroes(int[] nums) {

        int tortoise = 0, hare = 0;

        while (hare < nums.Length)
        {
            if (nums[hare] == 0)
                ++hare;

            else
                nums[tortoise++] = nums[hare++];
        }

        while (tortoise < nums.Length)
            nums[tortoise++] = 0;
       
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
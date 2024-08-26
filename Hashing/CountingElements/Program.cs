/*
    LeetCode 4661
    Counting Elements (easy)

    Given an integer array arr, count how many elements x there are,
    such that x + 1 is also in arr. If there are duplicates in arr,
    count them separately.

    Constraints:

    1 <= arr.length <= 1000
    0 <= arr[i] <= 1000
*/

using System.Text;
using System.Collections;

internal class Program {

    public static void Main(string[] args) {

        int[] input1 = [1, 2, 3];
        // output: 2

        int[] input2 = [1, 1, 3, 3, 5, 5, 7, 7];
        // output: 0

        Console.WriteLine("input 1: " + IntArrayToString(input1));
        Console.WriteLine("output 1: " + CountElements(input1));
        Console.WriteLine();

        Console.WriteLine("input 2: " + IntArrayToString(input2));
        Console.WriteLine("output 2: " + CountElements(input2));
        Console.WriteLine();



    }

    public static int CountElements(int[] arr) {

        int result = 0;
        int len = arr.Length;

        HashSet<int> h = new HashSet<int>(arr);

        for (int i = 0; i < len; ++i)
            if (h.Contains(arr[i] + 1))
                ++result;

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
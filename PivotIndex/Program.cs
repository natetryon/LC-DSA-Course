/*
    LeetCode 724
    Find Pivot Index (Easy)

    Given an array of integers nums, calculate the pivot index of this array.
    The pivot index is the index where the sum of all the numbers strictly to the left of the index
    is equal to the sum of all the numbers strictly to the index's right.

    If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left.
    This also applies to the right edge of the array.

    Return the leftmost pivot index. If no such index exists, return -1.

    Constraints:

    1 <= nums.length <= 10^4
    -1000 <= nums[i] <= 1000

*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] nums1 = [1, 7, 3, 6, 5, 6];
        // output: 3

        int[] nums2 = [1, 2, 3];
        // output: -1

        int[] nums3 = [2, 1, -1];
        // output: 0

        Console.WriteLine("input: " + IntArrayToString(nums1));
        Console.WriteLine("output: " + PivotIndex(nums1));
        Console.WriteLine();

        Console.WriteLine("input: " + IntArrayToString(nums2));
        Console.WriteLine("output: " + PivotIndex(nums2));
        Console.WriteLine();

        Console.WriteLine("input: " + IntArrayToString(nums3));
        Console.WriteLine("output: " + PivotIndex(nums3));
    }

    public static int PivotIndex(int[] nums) {

        int len = nums.Length;

        int[] pivotLeft = new int[len];
        int[] pivotRight = new int[len];

        pivotLeft[0] = 0;
        pivotRight[len - 1] = 0;

        for (int i = 1; i < len; ++i)
        {
            pivotLeft[i] = pivotLeft[i - 1] + nums[i - 1];
            pivotRight[len - 1 - i] = pivotRight[len - i] + nums[len - i];
        }

        for (int j = 0; j < len; ++j)
        {
            if (pivotLeft[j] == pivotRight[j])
                return j;
        }

        return -1;
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
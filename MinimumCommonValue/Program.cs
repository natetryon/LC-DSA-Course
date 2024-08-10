/*
    LeetCode 2540
    Minimum Common Value (Easy)

    Given two integer arrays nums1 and nums2, sorted in non-decreasing order,
    return the minimum integer common to both arrays. If there is no common
    integer amongst nums1 and nums2, return -1.

    Note that an integer is said to be common to nums1 and nums2 if both arrays have at least one
    occurrence of that integer.

    Constraints:

    1 <= nums1.length, nums2.length <= 10^5
    1 <= nums1[i], nums2[i] <= 10^9
    Both nums1 and nums2 are sorted in non-decreasing order.
*/

using System.Text;

internal class Program {

    public static void Main(string[] args) {

        int[] nums1a = [1, 2, 3];
        int[] nums2a = [2, 4];
        // expected output: 2

        int[] nums1b = [1, 2, 3, 6];
        int[] nums2b = [2, 3, 4, 5];
        // expected output: 2

        Console.WriteLine("Input: nums1 = " + IntArrayToString(nums1a) + ", nums2 = " + IntArrayToString(nums2a));
        Console.WriteLine("Output: " + GetCommon(nums1a, nums2a));
        Console.WriteLine();

        Console.WriteLine("Input: nums1 = " + IntArrayToString(nums1b) + ", nums2 = " + IntArrayToString(nums2b));
        Console.WriteLine("Output: " + GetCommon(nums1b, nums2b));
        Console.WriteLine();


    }

    public static int GetCommon(int[] nums1, int[] nums2) {

        int i = 0, j = 0;

        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] == nums2[j])
                return nums1[i];

            else if (nums1[i] > nums2[j])
                ++j;

            else
                ++i;
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